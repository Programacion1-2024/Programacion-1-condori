using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CDatos.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dni = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_CLIENTE", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "CuentaBancarias",
                columns: table => new
                {
                    IdCuenta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NroCuenta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Saldo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IdEstado = table.Column<int>(type: "int", nullable: false),
                    IdCliente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID.CUENTA", x => x.IdCuenta);
                    table.ForeignKey(
                        name: "FK_CuentaBancarias_Clientes_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TarjetaCreditos",
                columns: table => new
                {
                    IdTarjeta = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NroTarjeta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LimiteCredito = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SaldoDisponible = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdCliente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ID_TARJETA", x => x.IdTarjeta);
                    table.ForeignKey(
                        name: "FK_TarjetaCreditos_Clientes_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CuentaBancarias_IdCliente",
                table: "CuentaBancarias",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_TarjetaCreditos_IdCliente",
                table: "TarjetaCreditos",
                column: "IdCliente");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CuentaBancarias");

            migrationBuilder.DropTable(
                name: "TarjetaCreditos");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
