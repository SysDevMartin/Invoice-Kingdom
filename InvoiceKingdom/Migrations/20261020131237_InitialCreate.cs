using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvoiceKingdom.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    InvoiceNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    DueDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Reference = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceWork",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    InvoiceId = table.Column<int>(type: "INTEGER", nullable: false),
                    WorkName = table.Column<string>(type: "TEXT", nullable: false),
                    WorkAmountUnits = table.Column<decimal>(type: "decimal(5, 2)", nullable: false),
                    PricePerWorkAmountUnit = table.Column<decimal>(type: "decimal(6, 2)", nullable: false),
                    VatRate = table.Column<decimal>(type: "decimal(3, 2)", nullable: false),
                    TaxReductionRate = table.Column<decimal>(type: "decimal(3, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceWork", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvoiceWork_Invoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceWork_InvoiceId",
                table: "InvoiceWork",
                column: "InvoiceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InvoiceWork");

            migrationBuilder.DropTable(
                name: "Invoices");
        }
    }
}
