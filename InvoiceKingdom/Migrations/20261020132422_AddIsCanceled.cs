using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvoiceKingdom.Migrations
{
    /// <inheritdoc />
    public partial class AddIsCanceled : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCanceled",
                table: "Invoices",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCanceled",
                table: "Invoices");
        }
    }
}
