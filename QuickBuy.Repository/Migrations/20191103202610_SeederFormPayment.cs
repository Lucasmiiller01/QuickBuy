using Microsoft.EntityFrameworkCore.Migrations;

namespace QuickBuy.Repository.Migrations
{
    public partial class SeederFormPayment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FormPayment",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 1, "Forma de pagamento Boleto", "Billet" });

            migrationBuilder.InsertData(
                table: "FormPayment",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 2, "Forma de pagamento CreditCard", "CreditCard" });

            migrationBuilder.InsertData(
                table: "FormPayment",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 3, "Forma de pagamento Deposit", "Deposit" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FormPayment",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FormPayment",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FormPayment",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
