using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AERHNIC.Migrations
{
    public partial class updatetableuserinroles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdRole",
                table: "Users_in_Roles");

            migrationBuilder.DropColumn(
                name: "IdUsuario",
                table: "Users_in_Roles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "IdRole",
                table: "Users_in_Roles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdUsuario",
                table: "Users_in_Roles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
