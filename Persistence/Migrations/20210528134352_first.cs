using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Persistence.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    CltId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CodeClt = table.Column<string>(type: "text", nullable: true),
                    RaisonSocial = table.Column<string>(type: "text", nullable: true),
                    Adresse = table.Column<string>(type: "text", nullable: true),
                    Tel = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.CltId);
                });

            migrationBuilder.CreateTable(
                name: "Produits",
                columns: table => new
                {
                    IdProd = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CodeProd = table.Column<string>(type: "text", nullable: true),
                    DesignationProd = table.Column<string>(type: "text", nullable: true),
                    PrixProd = table.Column<decimal>(type: "numeric", nullable: false),
                    QuantiteProd = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produits", x => x.IdProd);
                });

            migrationBuilder.CreateTable(
                name: "CommandeEntetes",
                columns: table => new
                {
                    IdCmdEnt = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DateCmd = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    NumeroCmd = table.Column<string>(type: "text", nullable: true),
                    MontantTot = table.Column<decimal>(type: "numeric", nullable: false),
                    ClientCltId = table.Column<int>(type: "integer", nullable: true),
                    IdClt = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommandeEntetes", x => x.IdCmdEnt);
                    table.ForeignKey(
                        name: "FK_CommandeEntetes_Clients_ClientCltId",
                        column: x => x.ClientCltId,
                        principalTable: "Clients",
                        principalColumn: "CltId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CommandeLignes",
                columns: table => new
                {
                    IdCmdLigne = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PrixProd = table.Column<decimal>(type: "numeric", nullable: false),
                    DateLigne = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    QteLigne = table.Column<decimal>(type: "numeric", nullable: false),
                    IdCmdEnt = table.Column<int>(type: "integer", nullable: false),
                    CommandeEnteteIdCmdEnt = table.Column<int>(type: "integer", nullable: true),
                    ProduitIdProd = table.Column<int>(type: "integer", nullable: true),
                    IdProd = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommandeLignes", x => x.IdCmdLigne);
                    table.ForeignKey(
                        name: "FK_CommandeLignes_CommandeEntetes_CommandeEnteteIdCmdEnt",
                        column: x => x.CommandeEnteteIdCmdEnt,
                        principalTable: "CommandeEntetes",
                        principalColumn: "IdCmdEnt",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CommandeLignes_Produits_ProduitIdProd",
                        column: x => x.ProduitIdProd,
                        principalTable: "Produits",
                        principalColumn: "IdProd",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CommandeEntetes_ClientCltId",
                table: "CommandeEntetes",
                column: "ClientCltId");

            migrationBuilder.CreateIndex(
                name: "IX_CommandeLignes_CommandeEnteteIdCmdEnt",
                table: "CommandeLignes",
                column: "CommandeEnteteIdCmdEnt");

            migrationBuilder.CreateIndex(
                name: "IX_CommandeLignes_ProduitIdProd",
                table: "CommandeLignes",
                column: "ProduitIdProd");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommandeLignes");

            migrationBuilder.DropTable(
                name: "CommandeEntetes");

            migrationBuilder.DropTable(
                name: "Produits");

            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
