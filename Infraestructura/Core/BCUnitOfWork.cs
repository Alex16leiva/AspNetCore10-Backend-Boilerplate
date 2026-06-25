using Dominio.Core;
using Dominio.Core.Extensions;
using Infraestructura.Context;
using Infraestructura.Core.Identity;
using Infraestructura.Core.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Transactions;

namespace Infraestructura.Core
{
    public class BCUnitOfWork : DbContext
    {
        public BCUnitOfWork(DbContextOptions<MyContext> context)
            : base(context)
        {
            // Command timeout is configured at the concrete DbContext level.
        }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        public virtual void Commit(TransactionInfo? transactionInfo)
        {
            if (transactionInfo.IsNull())
            {
                throw new ArgumentNullException(nameof(transactionInfo), "TransactionInfo cannot be null.");
            }
            Logging.Transaction transaction = BuildTransactionInfo(transactionInfo);
            Commit(transaction, transactionInfo.GenerateTransaction);
        }

        private void Commit(Logging.Transaction transaction, bool generateTransaction)
        {
            try
            {
                base.Database.OpenConnection();
                //Reseteando el detalle de las transacciones.
                transaction.TransactionDetail = [];

                using (var scope = TransactionScopeFactory.GetTransactionScope())
                {
                    var changedEntities = new List<ModifiedEntityEntry>();
                    var tableMapping = new List<EntityMapping>();
                    var sqlCommandInfos = new List<SqlCommandInfo>();

                    IEnumerable<EntityEntry> changeDbEntityEntries = GetChangedDbEntityEntries();

                    foreach (EntityEntry entry in changeDbEntityEntries)
                    {
                        ApplyTransactionInfo(transaction, entry);

                        if (!generateTransaction)
                        {
                            // Get the deleted records info first
                            if (entry.State == EntityState.Deleted)
                            {
                                EntityMapping? entityMapping = GetEntityMappingConfiguration(tableMapping, entry);
                                if (entityMapping.IsNull())
                                {
                                    throw new NullReferenceException($"No se pudo encontrar el mapeo de la entidad para el tipo: {entry.Entity.GetType().Name}");
                                }
                                SqlCommandInfo? sqlCommandInfo = GetSqlCommandInfo(transaction, entry, entityMapping);
                                if (sqlCommandInfo != null) sqlCommandInfos.Add(sqlCommandInfo);

                                transaction.AddDetail(entityMapping.TableName, entry.State.ToString(), transaction.TransactionType);
                            }
                            else
                            {
                                changedEntities.Add(new ModifiedEntityEntry(entry, entry.State.ToString()));
                            }
                        }

                    }
                    base.SaveChanges();

                    if (!generateTransaction)
                    {
                        // Get the Added and Mdified records after changes, that way we will be able to get the generated .
                        foreach (ModifiedEntityEntry entry in changedEntities)
                        {
                            EntityMapping? entityMapping = GetEntityMappingConfiguration(tableMapping, entry.EntityEntry);
                            if (entityMapping.IsNull())
                            {
                                throw new NullReferenceException($"No se pudo encontrar el mapeo de la entidad para el tipo: {entry.EntityEntry.Entity.GetType().Name}");
                            }
                            SqlCommandInfo? sqlCommandInfo = GetSqlCommandInfo(transaction, entry.EntityEntry, entityMapping);
                            if (sqlCommandInfo != null) sqlCommandInfos.Add(sqlCommandInfo);
                            
                            transaction.AddDetail(entityMapping.TableName, entry.State, transaction.TransactionType);
                        }

                        // Adding Audit Detail Transaction CommandInfo.
                        sqlCommandInfos.AddRange(GetAuditRecords(transaction));

                        // Insert Transaction and audit records.
                        foreach (SqlCommandInfo sqlCommandInfo in sqlCommandInfos)
                        {
                            Database.ExecuteSqlRaw(sqlCommandInfo.Sql, sqlCommandInfo.Parameters);
                        }

                    }

                    scope.Complete();
                }
            }
            finally
            {

                base.Database.CloseConnection();    
            }
        }

        private IEnumerable<SqlCommandInfo> GetAuditRecords(Logging.Transaction transaction)
        {
            var auditCommands = new List<SqlCommandInfo>
            {
                // Adding Audit Header Transaction CommandInfo.
                GetAuditHeaderCommandInfo(transaction)
            };

            // Adding Audit Detail Transaction CommandInfo
            foreach (var transactionDetail in transaction.TransactionDetail)
            {
                auditCommands.Add(GetAuditDetailCommandInfo(transactionDetail));
            }

            return auditCommands;
        }

        private SqlCommandInfo GetAuditDetailCommandInfo(TransactionDetail transactionDetail)
        {
            const string sqlInsert =
                "insert into  Comunes.LogTransaccionesDetalle(TransaccionUId,TipoTransaccion, EntidadDominio, DescripcionTransaccion) " +
                                       "values({0}, {1}, {2},{3})";

            var param = new object[]
                                 {
                                     transactionDetail.TransactionId,transactionDetail.TransactionType, transactionDetail.TableName, transactionDetail.CrudOperation
                                 };

            return new SqlCommandInfo(sqlInsert, param);
        }

        private SqlCommandInfo GetAuditHeaderCommandInfo(Logging.Transaction transaction)
        {
            const string sqlInsert =
                "insert into  Comunes.LogTransacciones(TransaccionUId, TipoTransaccion, FechaTransaccion, ModificadoPor, OrigenTransaccion) " +
                "values({0}, {1}, {2}, {3}, {4} )";

            var param = new object[]
                                 {
                                     transaction.TransactionId, transaction.TransactionType, transaction.TransactionDate,
                                     transaction.ModifiedBy, transaction.TransactionOrigen
                                 };

            return new SqlCommandInfo(sqlInsert, param);
        }

        private SqlCommandInfo? GetSqlCommandInfo(Logging.Transaction transaction, EntityEntry entry, EntityMapping entityMapping)
        {
            if (entityMapping.TableName.Contains("_Transacciones"))
            {
                return null;
            }

            string sqlInsert;
            object[] param;
            CreateTransactionInsertStatement(entityMapping, entry, transaction, out sqlInsert, out param);

            var sqlCommandInfo = new SqlCommandInfo(sqlInsert, param);
            return sqlCommandInfo;
        }

        private void CreateTransactionInsertStatement(EntityMapping entityMapping, EntityEntry entry,
                                                      Logging.Transaction transaction, out string sqlInsert, out object[] objects)
        {
            var insert = new StringBuilder();
            var fields = new StringBuilder();
            var paramNames = new StringBuilder();
            List<object> values = [];

            insert.AppendLine(string.Format("Insert Into {0} ", entityMapping.TransactionTableName));

            int index = 0;
            IEnumerable<string> propertyNames = entry.State == EntityState.Deleted
                                                    ? GetPropertiesEntity(entry, entry.OriginalValues)
                                                    : GetPropertiesEntity(entry, entry.CurrentValues);

            foreach (string property in propertyNames)
            {
                string prop = property;
                if (prop != "RowVersion")
                {
                    if (fields.Length == 0)
                    {
                        fields.Append(string.Format(" ({0}", prop));
                        paramNames.Append(string.Format(" values ({0}{1}{2}", "{", index, "}"));
                    }
                    else
                    {
                        fields.Append(string.Format(", {0}", prop));
                        paramNames.Append(string.Format(", {0}{1}{2}", "{", index, "}"));
                    }
                    object? entityProperty = GetEntityPropertyValue(entry, property, transaction);
                    if (entityProperty.IsNotNull())
                    {
                        values.Add(entityProperty);
                        index++;
                    }
                }
            }

            fields.Append(string.Format(") "));
            paramNames.Append(string.Format(") "));

            insert.AppendLine(fields.ToString());
            insert.AppendLine(paramNames.ToString());

            sqlInsert = insert.ToString();
            objects = values.ToArray();
        }

        private object? GetEntityPropertyValue(EntityEntry? entry, string? prop, Logging.Transaction? transaction)
        {
            // 1. Validación defensiva de parámetros
            if (entry.IsNull() || prop.IsMissingValue() || transaction.IsNull())
            {
                return null;
            }

            // 2. Intentar obtener info de la transacción
            if (TryGeTransactionInfo(prop, transaction, out var value) && value.IsNotNull())
            {
                return value;
            }

            // 3. Manejo de estado de entidad
            if (entry.State == EntityState.Deleted || entry.State == EntityState.Detached)
            {
                if (prop == "DescripcionTransaccion")
                {
                    return entry.State.ToString();
                }

                // Usamos la propiedad de forma segura
                return entry.Property(prop).OriginalValue;
            }

            // 4. Valor actual
            return entry.Property(prop).CurrentValue;
        }

        private static bool TryGeTransactionInfo(string property, Logging.Transaction transaction, out object? value)
        {
            if (transaction.IsNull())
            {
                value = null;
                return false;
            }

            switch (property)
            {
                case "TransaccionUId":
                    value = transaction.TransactionId;
                    break;

                case "TipoTransaccion":
                    value = transaction.TransactionType;
                    break;

                case "FechaTransaccion":
                    value = transaction.TransactionDate;
                    break;

                case "ModificadoPor":
                    value = transaction.ModifiedBy;
                    break;

                default:
                    value = null;
                    break;
            }

            return value.IsNotNull();
        }

        private List<string> GetPropertiesEntity(EntityEntry? entry, PropertyValues? originalValues)
        {
            // 1. Guardar contra entry nulo
            if (entry.IsNull() || entry.OriginalValues.IsNull())
            {
                return new List<string>();
            }

            List<string> propertyNames = new();
            var entity = entry.Entity;
            var entityType = entity.GetType();
            var properties = entry.OriginalValues.Properties;

            foreach (var prop in properties)
            {
                // 2. Usar GetProperty de forma segura
                var propertyInfo = entityType.GetProperty(prop.Name);

                // Si no existe la propiedad en el tipo, la saltamos
                if (propertyInfo.IsNull())
                    continue;

                // 3. Obtener el valor y verificar nulo
                var value = propertyInfo.GetValue(entity);

                // Usamos tu extensión IsNotNull (si está disponible) o 'is not null'
                if (value.IsNotNull())
                {
                    propertyNames.Add(prop.Name);
                }
            }

            return propertyNames;
        }

        private static EntityMapping? GetEntityMappingConfiguration(List<EntityMapping> tableMapping, EntityEntry entry)
        {
            // 1. Validamos que el tipo de dominio no sea nulo
            var type = GetDomainEntityType(entry);
            if (type.IsNull()) return null;

            var name = entry.Metadata.GetTableName();
            var schema = entry.Metadata.GetSchema();
            var nameTable = $"{schema}.{name}"; // Usamos interpolación de strings, es más limpio

            // 2. Buscamos el mapeo (puede ser null)
            EntityMapping? entityMapping = tableMapping.FirstOrDefault(m => m.EntityType == type);

            if (entityMapping.IsNull())
            {
                entityMapping = CreateTableMapping(type, nameTable);
                tableMapping.Add(entityMapping);
            }

            return entityMapping;
        }

        private static EntityMapping CreateTableMapping(Type type, string tname)
        {
            return new EntityMapping { EntityType = type, TableName = tname, TransactionTableName = GetTransactionTableName(tname) };
        }

        private static string GetTransactionTableName(string tname)
        {
            if (tname.Contains("_Transacciones"))
            {
                return tname;
            }


            string result = string.Format("{0}_Transacciones", tname);
            return result;
        }

        private static Type? GetDomainEntityType(EntityEntry entry)
        {
            var type = entry.Entity.GetType();

            // 1. Si el tipo actual ya es del dominio, lo devolvemos
            // (Asegúrate de que 'TuNamespace' sea el namespace real de tu capa de dominio)
            if (type.Namespace?.Contains("Dominio") == true)
            {
                return type;
            }

            // 2. Si es un proxy de EF (clase generada dinámicamente), 
            // el tipo real suele ser el BaseType.
            var baseType = type.BaseType;

            // Verificamos si el tipo base pertenece al dominio
            if (baseType != null && baseType.Namespace?.Contains("Dominio") == true)
            {
                return baseType;
            }

            return null;
        }

        private static void ApplyTransactionInfo(Logging.Transaction transaction, EntityEntry entry)
        {
            ((Entity)entry.Entity).FechaTransaccion = transaction.TransactionDate;
            ((Entity)entry.Entity).DescripcionTransaccion = entry.State.ToString();
            ((Entity)entry.Entity).ModificadoPor = transaction.ModifiedBy;

            AplicarInformacionTransaccion(entry, "TipoTransaccion", transaction.TransactionType);
            AplicarInformacionTransaccion(entry, "TransaccionUId", transaction.TransactionId);
        }

        private static void AplicarInformacionTransaccion(EntityEntry item, string nombrePropiedad, object valorPropiedad)
        {
            if (item.IsNotNull() && item.Entity.IsNotNull() && nombrePropiedad.IsNotNull())
            {
                PropertyInfo? propInfoEntity = item.Entity.GetType().GetProperty(nombrePropiedad);
                if (propInfoEntity.IsNotNull())
                {
                    propInfoEntity.SetValue(item.Entity, valorPropiedad, null);
                }
            }
        }

        private IEnumerable<EntityEntry> GetChangedDbEntityEntries()
        {
            return ChangeTracker.Entries().Where(
                e =>
                (e.Entity is Entity) &&
                (e.State == EntityState.Modified || e.State == EntityState.Added || e.State == EntityState.Deleted));
        }

        private static Logging.Transaction BuildTransactionInfo(TransactionInfo transactionInfo)
        {
            var transaccionId = NewSequentialTransactionIdentity();

            return new Logging.Transaction
            {
                TransactionId = transaccionId.TransactionId,
                TransactionDate = transaccionId.TransactionDate,
                TransactionOrigen = transactionInfo.TipoTransaccion,
                TransactionType = transactionInfo.TipoTransaccion,
                ModifiedBy = transactionInfo.ModificadoPor.IsMissingValue() ? "Sistema" : transactionInfo.ModificadoPor
            };
        }

        public static TransactionIdentity NewSequentialTransactionIdentity()
        {
            return new TransactionIdentity
            {
                TransactionId = NewSequentialGuid(),
                TransactionDate = DateTime.Now,
                TransactionUtcDate = DateTime.UtcNow
            };
        }

        public static Guid NewSequentialGuid()
        {
            byte[] uid = Guid.NewGuid().ToByteArray();
            byte[] binDate = BitConverter.GetBytes(DateTime.UtcNow.Ticks);

            var secuentialGuid = new byte[uid.Length];

            secuentialGuid[0] = uid[0];
            secuentialGuid[1] = uid[1];
            secuentialGuid[2] = uid[2];
            secuentialGuid[3] = uid[3];
            secuentialGuid[4] = uid[4];
            secuentialGuid[5] = uid[5];
            secuentialGuid[6] = uid[6];
            // set the first part of the 8th byte to '1100' so
            // later we'll be able to validate it was generated by us

            secuentialGuid[7] = (byte)(0xc0 | (0xf & uid[7]));

            // the last 8 bytes are sequential,
            // it minimizes index fragmentation
            // to a degree as long as there are not a large
            // number of Secuential-Guids generated per millisecond

            secuentialGuid[9] = binDate[0];
            secuentialGuid[8] = binDate[1];
            secuentialGuid[15] = binDate[2];
            secuentialGuid[14] = binDate[3];
            secuentialGuid[13] = binDate[4];
            secuentialGuid[12] = binDate[5];
            secuentialGuid[11] = binDate[6];
            secuentialGuid[10] = binDate[7];

            return new Guid(secuentialGuid);
        }

        public void RollbackChanges()
        {
            //Set all entities in change tracker
            //as 'unchanged state'
            ChangeTracker.Entries()
                .ToList().ForEach(e => e.State = EntityState.Unchanged);
        }

        public int ExecuteCommand(string sqlCommand, params object[] parameters)
        {
            return Database.ExecuteSqlRaw(sqlCommand, parameters);
        }

        public IEnumerable<TEntity> ExecuteQuery<TEntity>(string sqlCommand, params object[] parameters) 
        {
            //return Set<TEntity>().FromSqlRaw(sqlCommand, parameters).ToList();

            return Database.SqlQueryRaw<TEntity>(sqlCommand, parameters);
        }

        public TType? ExecuteScalarFunction<TType>(string scalarFunction, params object[] parameters)
        {
            var returnValue = Database.SqlQueryRaw<TType>(scalarFunction, parameters);

            return returnValue.FirstOrDefault();
        }

        public async Task<IEnumerable<TEntity>> ExecuteQueryAsync<TEntity>(string sqlCommand, params object[] parameters) where TEntity: class
        {
            return await Set<TEntity>().FromSqlRaw(sqlCommand, parameters).ToListAsync();
        }

        public DbSet<TEntity> CreateSet<TEntity>() where TEntity : class
        {
            return Set<TEntity>();
        }

        public new void Attach<TEntity>(TEntity item) where TEntity : class
        {
            // Attach y set como unchanged
            base.Attach(item).State = EntityState.Unchanged;
        }

        public void SetModified<TEntity>(TEntity item) where TEntity : class
        {
            //This operation also attach item in object state manager
            Entry(item).State = EntityState.Modified;
        }

        public void ApplyCurrentValues<TEntity>(TEntity original, TEntity current) where TEntity : class
        {
            Entry(original).CurrentValues.SetValues(current);
        }
    }
}
