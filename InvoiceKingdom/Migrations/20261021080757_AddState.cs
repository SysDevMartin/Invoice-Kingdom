using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvoiceKingdom.Migrations
{
    /// <inheritdoc />
    public partial class AddState : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsCanceled",
                table: "Invoices",
                newName: "State");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "State",
                table: "Invoices",
                newName: "IsCanceled");
        }
    }
}
