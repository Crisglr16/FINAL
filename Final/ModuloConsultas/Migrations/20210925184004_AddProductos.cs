using Microsoft.EntityFrameworkCore.Migrations;

namespace ModuloConsultas.Migrations
{
    public partial class AddProductos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    CodigoProducto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreProducto = table.Column<string>(type: "varchar(35)", nullable: false),
                    CantidadProducto = table.Column<int>(type: "int", nullable: false),
                    FechaIngreso = table.Column<string>(type: "varchar(35)", nullable: false),
                    FechaVencimiento = table.Column<string>(type: "varchar(35)", nullable: false),
                    CodigoProveedor = table.Column<int>(type: "int", nullable: false),
                    NombreProveedor = table.Column<string>(type: "varchar(35)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.CodigoProducto);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productos");
        }
    }
}
