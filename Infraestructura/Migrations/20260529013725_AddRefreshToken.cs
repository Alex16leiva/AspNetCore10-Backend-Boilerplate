using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infraestructura.Migrations
{
    /// <inheritdoc />
    public partial class AddRefreshToken : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "comunes");

            migrationBuilder.EnsureSchema(
                name: "Comunes");

            migrationBuilder.EnsureSchema(
                name: "Seguridad");

            migrationBuilder.CreateTable(
                name: "Configuraciones",
                schema: "comunes",
                columns: table => new
                {
                    ConfiguracionId = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    ModificadoPor = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    FechaTransaccion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DescripcionTransaccion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    RowVersion = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    TransaccionUId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoTransaccion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configuraciones", x => x.ConfiguracionId);
                });

            migrationBuilder.CreateTable(
                name: "Pantalla",
                schema: "Seguridad",
                columns: table => new
                {
                    PantallaId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    ModificadoPor = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    FechaTransaccion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DescripcionTransaccion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    RowVersion = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    TransaccionUId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoTransaccion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pantalla", x => x.PantallaId);
                });

            migrationBuilder.CreateTable(
                name: "Rol",
                schema: "Seguridad",
                columns: table => new
                {
                    RolId = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    ModificadoPor = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    FechaTransaccion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DescripcionTransaccion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    RowVersion = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    TransaccionUId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoTransaccion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.RolId);
                });

            migrationBuilder.CreateTable(
                name: "ConfiguracionesDetalle",
                schema: "Comunes",
                columns: table => new
                {
                    ConfiguracionId = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Atributo = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Valor = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModificadoPor = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    FechaTransaccion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DescripcionTransaccion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    RowVersion = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    TransaccionUId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoTransaccion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfiguracionesDetalle", x => new { x.ConfiguracionId, x.Atributo });
                    table.ForeignKey(
                        name: "FK_ConfiguracionesDetalle_Configuraciones_ConfiguracionId",
                        column: x => x.ConfiguracionId,
                        principalSchema: "comunes",
                        principalTable: "Configuraciones",
                        principalColumn: "ConfiguracionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Permisos",
                schema: "Seguridad",
                columns: table => new
                {
                    RolId = table.Column<string>(type: "varchar(25)", nullable: false),
                    PantallaId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ver = table.Column<bool>(type: "bit", nullable: false),
                    Editar = table.Column<bool>(type: "bit", nullable: false),
                    Eliminar = table.Column<bool>(type: "bit", nullable: false),
                    ModificadoPor = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    FechaTransaccion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DescripcionTransaccion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    RowVersion = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    TransaccionUId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoTransaccion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permisos", x => new { x.RolId, x.PantallaId });
                    table.ForeignKey(
                        name: "FK_Permisos_Rol_RolId",
                        column: x => x.RolId,
                        principalSchema: "Seguridad",
                        principalTable: "Rol",
                        principalColumn: "RolId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                schema: "Seguridad",
                columns: table => new
                {
                    UsuarioId = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    Contrasena = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    RolId = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshTokenExpiryTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModificadoPor = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    FechaTransaccion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DescripcionTransaccion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    RowVersion = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    TransaccionUId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoTransaccion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
                    table.ForeignKey(
                        name: "FK_Usuario_Rol_RolId",
                        column: x => x.RolId,
                        principalSchema: "Seguridad",
                        principalTable: "Rol",
                        principalColumn: "RolId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_RolId",
                schema: "Seguridad",
                table: "Usuario",
                column: "RolId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConfiguracionesDetalle",
                schema: "Comunes");

            migrationBuilder.DropTable(
                name: "Pantalla",
                schema: "Seguridad");

            migrationBuilder.DropTable(
                name: "Permisos",
                schema: "Seguridad");

            migrationBuilder.DropTable(
                name: "Usuario",
                schema: "Seguridad");

            migrationBuilder.DropTable(
                name: "Configuraciones",
                schema: "comunes");

            migrationBuilder.DropTable(
                name: "Rol",
                schema: "Seguridad");
        }
    }
}
