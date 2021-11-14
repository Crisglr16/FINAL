using Microsoft.EntityFrameworkCore.Migrations;

namespace ModuloConsultas.Migrations
{
    public partial class Migra6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstadoProducto",
                table: "Productos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EstadoProducto",
                table: "Productos",
                type: "varchar(5)",
                nullable: true);
        }
    }
}
