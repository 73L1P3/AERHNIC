using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AERHNIC.Migrations
{
    public partial class againmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    IdRole = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NombreRole = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.IdRole);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre_Usuario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Correo_Usuario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cargo_Usuario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Empresa_Usuario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Telefono_Celular_Usuario = table.Column<int>(type: "int", nullable: false),
                    Telefono_Empresa_Usuario = table.Column<int>(type: "int", nullable: false),
                    Cedula_Usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contacto_Pago_Usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comentario_Usuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fecha_Nacimiento_Usuario = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Registro_Usuario = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado_Usuario = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Users_in_Roles",
                columns: table => new
                {
                    Id_User_Role = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdRole = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RolesIdRole = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UsuariosUsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users_in_Roles", x => x.Id_User_Role);
                    table.ForeignKey(
                        name: "FK_Users_in_Roles_Roles_RolesIdRole",
                        column: x => x.RolesIdRole,
                        principalTable: "Roles",
                        principalColumn: "IdRole",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_in_Roles_Usuarios_UsuariosUsuarioId",
                        column: x => x.UsuariosUsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_in_Roles_RolesIdRole",
                table: "Users_in_Roles",
                column: "RolesIdRole");

            migrationBuilder.CreateIndex(
                name: "IX_Users_in_Roles_UsuariosUsuarioId",
                table: "Users_in_Roles",
                column: "UsuariosUsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users_in_Roles");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
