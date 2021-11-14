using Microsoft.EntityFrameworkCore.Migrations;

namespace ModuloConsultas.Migrations
{
    public partial class Migra2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EstadoProducto",
                table: "Productos",
                type: "varchar(5)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstadoProducto",
                table: "Productos");
        }
    }
}
