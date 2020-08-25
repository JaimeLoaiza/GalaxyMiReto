using Microsoft.EntityFrameworkCore.Migrations;

namespace GalaxyMiReto.Migrations
{
    public partial class MigracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contrato",
                columns: table => new
                {
                    ContratoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContratoNumero = table.Column<int>(maxLength: 5, nullable: false),
                    EntityName = table.Column<string>(maxLength: 50, nullable: false),
                    ContractWorker = table.Column<string>(maxLength: 2, nullable: false),
                    InitialDate = table.Column<string>(maxLength: 8, nullable: false),
                    FinalDate = table.Column<string>(maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contrato", x => x.ContratoId);
                });

            migrationBuilder.CreateTable(
                name: "Developer",
                columns: table => new
                {
                    DeveloperId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentityType = table.Column<string>(maxLength: 2, nullable: false),
                    NumberIdentity = table.Column<string>(maxLength: 5, nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    SecondName = table.Column<string>(maxLength: 50, nullable: false),
                    FirstLastName = table.Column<string>(maxLength: 50, nullable: false),
                    SecondLastName = table.Column<string>(maxLength: 50, nullable: false),
                    DateBirth = table.Column<string>(maxLength: 8, nullable: false),
                    Age = table.Column<string>(maxLength: 2, nullable: false),
                    ContractId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Developer", x => x.DeveloperId);
                    table.ForeignKey(
                        name: "FK_Developer_Contrato_ContractId",
                        column: x => x.ContractId,
                        principalTable: "Contrato",
                        principalColumn: "ContratoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Developer_ContractId",
                table: "Developer",
                column: "ContractId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Developer");

            migrationBuilder.DropTable(
                name: "Contrato");
        }
    }
}
