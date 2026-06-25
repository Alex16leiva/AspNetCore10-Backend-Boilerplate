
using Dominio.Core;
using Dominio.Core.Extensions;
using Infraestructura.Core;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Linq.Dynamic;
using System.Linq.Expressions;
using System.Text.RegularExpressions;


namespace Infraestructura.Context
{
    public class GenericRepository<T>(T unitOfWork, IConfiguration configuration) : IGenericRepository<T>
        where T : IQueryableUnitOfWork
    {
        private readonly T _unitOfWork = unitOfWork;
        private readonly IConfiguration _configuration = configuration;

        private static readonly Regex SqlIdentifierRegex = new(@"^[A-Za-z_][A-Za-z0-9_]*(\.[A-Za-z_][A-Za-z0-9_]*)?$", RegexOptions.Compiled);
        private static readonly Regex SqlParameterNameRegex = new(@"^@[A-Za-z_][A-Za-z0-9_]*$", RegexOptions.Compiled);
        private static readonly string[] UnsafeSqlTokens = [";", "--", "/*", "*/"];

        private DbSet<TEntity> GetSet<TEntity>() where TEntity : class
        {
            return _unitOfWork.CreateSet<TEntity>();
        }

        public IUnitOfWork UnitOfWork
        { 
            get { return _unitOfWork; } 
        }

        /// <inheritdoc/>
        public void Add<TEntity>(TEntity entity) where TEntity : Entity
        {
            if (entity.IsNotNull())
            {
                entity.FechaTransaccion = DateTime.Now;
                entity.DescripcionTransaccion = "Insert";
                entity.RowVersion = [];
                GetSet<TEntity>().Add(entity); //Add new item in this set
            }
        }

        /// <inheritdoc/>
        public async Task AddAsync<TEntity>(TEntity entity) where TEntity : Entity
        {
            if (entity.IsNotNull())
            {
                entity.FechaTransaccion = DateTime.Now;
                entity.DescripcionTransaccion = "Insert";
                entity.RowVersion = [];
                await GetSet<TEntity>().AddAsync(entity); //Add new item in this set
            }
        }

        /// <inheritdoc/>
        public void AddRange<TEntity>(IEnumerable<TEntity> entities)
            where TEntity : Entity
        {
            if (entities.HasItems())
            {
                GetSet<TEntity>().AddRange(entities);
            }
        }

        /// <inheritdoc/>
        public async Task AddRangeAsync<TEntity>(IEnumerable<TEntity> entities) 
            where TEntity : Entity
        {
            if (entities.HasItems())
            {
                await GetSet<TEntity>().AddRangeAsync(entities);
            }
        }

        public void Dispose()
        {
            if (_unitOfWork.IsNotNull())
            {
                _unitOfWork.Dispose();
            }
        }

        /// <inheritdoc/>
        public IEnumerable<TEntity> GetAll<TEntity>() 
            where TEntity : Entity
        {
            return [.. GetSet<TEntity>()];
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<TEntity>> GetAllAsync<TEntity>()
            where TEntity : Entity
        {
            return await GetSet<TEntity>().ToListAsync();
        }
        
        /// <inheritdoc/>
        public IEnumerable<TEntity> GetAll<TEntity>(List<string> includes) 
            where TEntity : Entity
        {
            IQueryable<TEntity> items = GetSet<TEntity>();

            if (includes.HasItems())
            {
                //Adding Includes to filter.
                items = includes.Aggregate(items, (current, include) => current.Include(include));
            }

            return [.. items];
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<TEntity>> GetAllAsync<TEntity>(List<string> includes)
            where TEntity : Entity
        {
            IQueryable<TEntity> items = GetSet<TEntity>();

            if (includes.HasItems())
            {
                //Adding Includes to filter.
                items = includes.Aggregate(items, (current, include) => current.Include(include));
            }

            return await items.ToListAsync();
        }

        /// <inheritdoc/>
        public TEntity? GetSingle<TEntity>(Expression<Func<TEntity, bool>> predicate) 
            where TEntity : Entity
        {
            return GetSet<TEntity>().FirstOrDefault(predicate);
        }

        /// <inheritdoc/>
        public async Task<TEntity?> GetSingleAsync<TEntity>(Expression<Func<TEntity, bool>> predicate) 
            where TEntity : Entity
        {
            return await GetSet<TEntity>().FirstOrDefaultAsync(predicate);
        }


        /// <inheritdoc/>
        public TEntity? GetSingle<TEntity>(Expression<Func<TEntity, bool>> predicate, List<string> includes)
            where TEntity : Entity
        {
            IQueryable<TEntity> items = GetSet<TEntity>();

            if (includes.HasItems())
            {
                //Adding include to the filter.
                items = includes.Aggregate(items, (current, include) => current.Include(include));
            }

            return items.FirstOrDefault(predicate);
        }

        /// <inheritdoc/>
        public async Task<TEntity?> GetSingleAsync<TEntity>(Expression<Func<TEntity, bool>> predicate, List<string> includes)
            where TEntity : Entity
        {
            IQueryable<TEntity> items = GetSet<TEntity>();

            if (includes.HasItems())
            {
                //Adding include to the filter.
                items = includes.Aggregate(items, (current, include) => current.Include(include));
            }

            return await items.FirstOrDefaultAsync(predicate);
        }

        /// <inheritdoc/>
        public IEnumerable<TEntity> GetFiltered<TEntity>(Expression<Func<TEntity, bool>> predicate)
            where TEntity : Entity
        {
            return [.. GetSet<TEntity>().Where(predicate)];
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<TEntity>> GetFilteredAsync<TEntity>(Expression<Func<TEntity, bool>> predicate)
            where TEntity : Entity
        {
            return await GetSet<TEntity>().Where(predicate).ToListAsync();
        }

        /// <inheritdoc/>
        public IEnumerable<TEntity> GetFiltered<TEntity>(Expression<Func<TEntity, bool>> predicate, List<string> includes)
            where TEntity : Entity
        {
            IQueryable<TEntity> items = GetSet<TEntity>();
            if (includes.HasItems())
            {
                //Adding includes to filter
                items = includes.Aggregate(items, (current, include) => current.Include(include));
            }

            return [.. items.Where(predicate)];
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<TEntity>> GetFilteredAsync<TEntity>(Expression<Func<TEntity, bool>> predicate, List<string> includes)
            where TEntity : Entity
        {
            IQueryable<TEntity> items = GetSet<TEntity>();
            if (includes.HasItems())
            {
                //Adding includes to filter
                items = includes.Aggregate(items, (current, include) => current.Include(include));
            }

            return await items.Where(predicate).ToListAsync();
        }

        public PagedCollection GetPagedAndFiltered<TEntity>(DynamicFilter filterDef)
            where TEntity : Entity
        {
            IQueryable<TEntity> items = !string.IsNullOrWhiteSpace(filterDef.Filtro)
                                            ? GetSet<TEntity>().Where(filterDef.Filtro, filterDef.Valores)
                                            : GetSet<TEntity>();

            if (filterDef.Includes.HasItems())
            {
                //Adding Includes to the filter
                items = filterDef.Includes.Aggregate(items, (current, include) => current.Include(include));
            }

            int totalItems = items.Count();

            if (filterDef.PageSize != 0)
            {
                //Adding sort criteria.
                if (filterDef.SortFields.HasItems())
                {
                    string orderKey = filterDef.Ascending ? "ASC" : "DESC";

                    var order = string.Join(" " + orderKey + ", ", filterDef.SortFields.ToArray());

                    if (!order.EndsWith(orderKey))
                    {
                        order += " " + orderKey;
                    }

                    items = items.OrderBy(order);

                    items = items.Skip(filterDef.PageSize * filterDef.PageIndex);
                }

                items = items.Take(filterDef.PageSize);
            }

            var pagedItems = items.ToList();

            return new PagedCollection(filterDef.PageIndex, filterDef.PageSize, pagedItems, totalItems, count: pagedItems.Count);
        }

        public async Task<PagedCollection> GetPagedAndFilteredAsync<TEntity>(DynamicFilter filterDef)
            where TEntity : Entity
        {
            IQueryable<TEntity> items = !string.IsNullOrWhiteSpace(filterDef.Filtro)
                                            ? GetSet<TEntity>().Where(filterDef.Filtro, filterDef.Valores)
                                            : GetSet<TEntity>();

            if (filterDef.Includes.HasItems())
            {
                //Adding Includes to the filter
                items = filterDef.Includes.Aggregate(items, (current, include) => current.Include(include));
            }

            int totalItems = items.Count();

            if (filterDef.PageSize != 0)
            {
                //Adding sort criteria.
                if (filterDef.SortFields.HasItems())
                {
                    string orderKey = filterDef.Ascending ? "ASC" : "DESC";

                    var order = string.Join(" " + orderKey + ", ", filterDef.SortFields.ToArray());

                    if (!order.EndsWith(orderKey))
                    {
                        order += " " + orderKey;
                    }

                    items = items.OrderBy(order);

                    items = items.Skip(filterDef.PageSize * filterDef.PageIndex);
                }

                items = items.Take(filterDef.PageSize);
            }

            var pagedItems = await items.ToListAsync();

            return new PagedCollection(filterDef.PageIndex, filterDef.PageSize, pagedItems, totalItems, pagedItems.Count);
        }

        /// <inheritdoc/>
        public void Remove<TEntity>(TEntity entity)
            where TEntity : Entity
        {
            if (entity.IsNotNull())
            {
                //Attach item if not exist
                _unitOfWork.Attach(entity);

                //set as "Remove"
                GetSet<TEntity>().Remove(entity);
            }
        }

        /// <inheritdoc/>
        public void RemoveRange<TEntity>(IEnumerable<TEntity> entities) 
            where TEntity : Entity
        {
            if (entities.HasItems())
            {
                //set as removed
                GetSet<TEntity>().RemoveRange(entities);
            }
        }

        /// <inheritdoc/>
        public void Modify<TEntity>(TEntity item)
            where TEntity : Entity
        {
            if (item.IsNotNull())
            {
                _unitOfWork.SetModified(item);
            }
        }

        public IEnumerable<TType> ExecuteStoredProcedure<TType>(string storedProcedure, Dictionary<string, object> parameters)
        {
            ValidateSqlIdentifier(storedProcedure, nameof(storedProcedure));
            SqlParameter[] sqlParameters = GenericRepository<T>.CreateSqlParameters(parameters);
            string paramNames = GenericRepository<T>.GetParamNames(parameters);

            return (string.IsNullOrWhiteSpace(paramNames))
                ? [.. _unitOfWork.ExecuteQuery<TType>(string.Format("EXEC {0}", storedProcedure), sqlParameters)]
                : [.. _unitOfWork.ExecuteQuery<TType>(string.Format("EXEC {0} {1}", storedProcedure, paramNames), sqlParameters)];
        }

        public IEnumerable<TType> ExecuteStoredProcedure<TType>(string storedProcedure, SqlParameter[] parameters)
        {
            ValidateSqlIdentifier(storedProcedure, nameof(storedProcedure));
            string paramNames = GenericRepository<T>.GetParamNames(parameters);
            return [.. _unitOfWork.ExecuteQuery<TType>(string.Format("EXEC {0} {1}", storedProcedure, paramNames), parameters)];
        }

        public TType ExecuteScalarFunction<TType>(string scalarFunction, Dictionary<string, object> parameters)
        {
            ValidateSqlIdentifier(scalarFunction, nameof(scalarFunction));
            SqlParameter[] sqlParameters = GenericRepository<T>.CreateSqlParameters(parameters);
            string paramNames = GenericRepository<T>.GetParamNames(parameters);

            var result = (string.IsNullOrWhiteSpace(paramNames))
                ? _unitOfWork.ExecuteScalarFunction<TType>(string.Format("SELECT {0}();", scalarFunction), sqlParameters)
                : _unitOfWork.ExecuteScalarFunction<TType>(string.Format("SELECT {0}({1});", scalarFunction, paramNames), sqlParameters);

            return result;
        }

        private static string GetParamNames(Dictionary<string, object> parameters)
        {
            ValidateSqlParameterNames(parameters?.Keys);
            return (parameters.IsNotNull() && parameters.HasItems())
                ? parameters.Select(p => p.Key).Aggregate((i, j) => i + ", " + j)
                : string.Empty;
        }

        private static string GetParamNames(SqlParameter[] parameters)
        {
            ValidateSqlParameterNames(parameters?.Select(p => p.ParameterName));
            return (parameters.IsNotNull() && parameters.HasItems())
                ? parameters.Select(p => p.ParameterName).Aggregate((i, j) => i + ", " + j)
                : string.Empty;
        }

        public void ExecuteQuery(string sqlQuery, Dictionary<string, object> parameters)
        {
            ValidateSqlCommand(sqlQuery);
            SqlParameter[] sqlParameters = GenericRepository<T>.CreateSqlParameters(parameters);
            _unitOfWork.ExecuteCommand(sqlQuery, sqlParameters);
        }

        private static SqlParameter[] CreateSqlParameters(Dictionary<string, object> parameters)
        {
            if (parameters.IsNotNull() && parameters.HasItems())
            {
                ValidateSqlParameterNames(parameters.Keys);
                return [.. (from qry in parameters select new SqlParameter(qry.Key, qry.Value))];
            }

            return [];
        }

        public void ExecuteQuery(SqlParameter[] parms, string sqlQuery)
        {
            // Si parms es nulo, usamos un array vacío para satisfacer el contrato
            var safeParams = parms ?? [];
            ValidateSqlCommand(sqlQuery);
            ValidateSqlParameterNames(safeParams.Select(p => p.ParameterName));
            _unitOfWork.ExecuteCommand(sqlQuery, safeParams);
        }

        public async Task<bool> IsRunningJobsAsync(string jobName)
        {
            if (string.IsNullOrWhiteSpace(jobName))
            {
                return false;
            }

            string connectionString = _configuration.GetConnectionString("conectionDataBase")
                ?? throw new InvalidOperationException("Connection string 'conectionDataBase' not found in configuration.");
            bool result = false;

            try
            {
                using SqlConnection connection = new(connectionString);
                await connection.OpenAsync();

                string query = "SELECT COUNT(*) FROM msdb.dbo.sysjobs j " +
                    "INNER JOIN msdb.dbo.sysjobactivity a " +
                    "  ON j.job_id = a.job_id " +
                    "WHERE j.name = @jobName AND a.run_requested_date IS NOT NULL AND a.stop_execution_date IS NULL";

                using SqlCommand command = new(query, connection);
                command.Parameters.Add(new SqlParameter("@jobName", jobName));
                int runningJobCount = (int)(await command.ExecuteScalarAsync() ?? 0);

                if (runningJobCount > 0)
                {
                    result = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: { ex.Message }");
            }

            return result;
        }

        public IEnumerable<TEntity> ExecuteQuery<TEntity>(SqlParameter[] parms, string sqlQuery)
        {
            // Si parms es nulo, usamos un array vacío para satisfacer el contrato
            var safeParams = parms ?? [];

            ValidateSqlCommand(sqlQuery);
            ValidateSqlParameterNames(safeParams.Select(p => p.ParameterName));
            return [.. _unitOfWork.ExecuteQuery<TEntity>(sqlQuery, safeParams)];
        }

        private static void ValidateSqlIdentifier(string identifier, string argumentName)
        {
            if (string.IsNullOrWhiteSpace(identifier) || !SqlIdentifierRegex.IsMatch(identifier))
            {
                throw new ArgumentException("Only simple schema-qualified SQL identifiers are allowed.", argumentName);
            }
        }

        private static void ValidateSqlParameterNames(IEnumerable<string>? parameterNames)
        {
            if (parameterNames.IsNull()) return;

            foreach (var parameterName in parameterNames)
            {
                if (string.IsNullOrWhiteSpace(parameterName) || !SqlParameterNameRegex.IsMatch(parameterName))
                {
                    throw new ArgumentException("SQL parameter names must start with @ and contain only letters, numbers, or underscores.");
                }
            }
        }

        private static void ValidateSqlCommand(string sqlQuery)
        {
            if (string.IsNullOrWhiteSpace(sqlQuery))
            {
                throw new ArgumentException("SQL query cannot be empty.", nameof(sqlQuery));
            }

            if (UnsafeSqlTokens.Any(token => sqlQuery.Contains(token, StringComparison.Ordinal)))
            {
                throw new ArgumentException("SQL query contains unsupported multi-statement or comment syntax.", nameof(sqlQuery));
            }
        }
    }
}
