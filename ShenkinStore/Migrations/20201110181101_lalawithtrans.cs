using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShenkinStore.Migrations
{
    public partial class lalawithtrans : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Products_ProductID",
                table: "Transaction");

            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_User_UserID",
                table: "Transaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transaction",
                table: "Transaction");

            migrationBuilder.DropIndex(
                name: "IX_Transaction_ProductID",
                table: "Transaction");

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "Transaction");

            migrationBuilder.DropColumn(
                name: "TransactionDate",
                table: "Transaction");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "Transaction",
                newName: "Transactions");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Transactions",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Transaction_UserID",
                table: "Transactions",
                newName: "IX_Transactions_UserId");

            migrationBuilder.AddColumn<string>(
                name: "CartId",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TransactionId",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "inCart",
                table: "Products",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "sold",
                table: "Products",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Transactions",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<decimal>(
                name: "Amount",
                table: "Transactions",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "CartShoppingCartId",
                table: "Transactions",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Delivery",
                table: "Transactions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Paid",
                table: "Transactions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "TransDate",
                table: "Transactions",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions",
                column: "TransactionId");

            migrationBuilder.CreateTable(
                name: "ShoppingCart",
                columns: table => new
                {
                    ShoppingCartId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCart", x => x.ShoppingCartId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_TransactionId",
                table: "Products",
                column: "TransactionId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_CartShoppingCartId",
                table: "Transactions",
                column: "CartShoppingCartId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Transactions_TransactionId",
                table: "Products",
                column: "TransactionId",
                principalTable: "Transactions",
                principalColumn: "TransactionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_ShoppingCart_CartShoppingCartId",
                table: "Transactions",
                column: "CartShoppingCartId",
                principalTable: "ShoppingCart",
                principalColumn: "ShoppingCartId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Users_UserId",
                table: "Transactions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Transactions_TransactionId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_ShoppingCart_CartShoppingCartId",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Users_UserId",
                table: "Transactions");

            migrationBuilder.DropTable(
                name: "ShoppingCart");

            migrationBuilder.DropIndex(
                name: "IX_Products_TransactionId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_CartShoppingCartId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "TransactionId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "inCart",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "sold",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "CartShoppingCartId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "Delivery",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "Paid",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "TransDate",
                table: "Transactions");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "Transactions",
                newName: "Transaction");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Transaction",
                newName: "UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_UserId",
                table: "Transaction",
                newName: "IX_Transaction_UserID");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Transaction",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "Transaction",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "TransactionDate",
                table: "Transaction",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transaction",
                table: "Transaction",
                column: "TransactionId");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_ProductID",
                table: "Transaction",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Products_ProductID",
                table: "Transaction",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_User_UserID",
                table: "Transaction",
                column: "UserID",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
