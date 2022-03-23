using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarServiceCenter.EF.Migrations
{
    public partial class FixedDecimalValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TransactionLines",
                table: "TransactionLines");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TransactionLines",
                table: "TransactionLines",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TransactionLines",
                table: "TransactionLines");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TransactionLines",
                table: "TransactionLines",
                column: "Price");
        }
    }
}
