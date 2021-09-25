using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUD_NETCore5.Migrations
{
    public partial class AgregandoNuevoModelo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    ID_Usuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    table.PrimaryKey("PK_Usuarios", x => x.ID_Usuario);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
