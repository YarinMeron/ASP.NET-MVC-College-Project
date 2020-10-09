using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShenkinStore.Migrations
{
    public partial class Shoppingcartmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Products_ProductID",
                table: "Transaction");

            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_User_UserID",
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

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Transaction",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Transaction_UserID",
                table: "Transaction",
                newName: "IX_Transaction_UserId");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Transaction",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<decimal>(
                name: "Amount",
                table: "Transaction",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "CartShoppingCartId",
                table: "Transaction",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Delivery",
                table: "Transaction",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Paid",
                table: "Transaction",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "TransDate",
                table: "Transaction",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CartId",
                table: "Products",
                nullable: true);

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
                name: "IX_Transaction_CartShoppingCartId",
                table: "Transaction",
                column: "CartShoppingCartId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_ShoppingCart_CartShoppingCartId",
                table: "Transaction",
                column: "CartShoppingCartId",
                principalTable: "ShoppingCart",
                principalColumn: "ShoppingCartId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_User_UserId",
                table: "Transaction",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_ShoppingCart_CartShoppingCartId",
                table: "Transaction");

            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_User_UserId",
                table: "Transaction");

            migrationBuilder.DropTable(
                name: "ShoppingCart");

            migrationBuilder.DropIndex(
                name: "IX_Transaction_CartShoppingCartId",
                table: "Transaction");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Transaction");

            migrationBuilder.DropColumn(
                name: "CartShoppingCartId",
                table: "Transaction");

            migrationBuilder.DropColumn(
                name: "Delivery",
                table: "Transaction");

            migrationBuilder.DropColumn(
                name: "Paid",
                table: "Transaction");

            migrationBuilder.DropColumn(
                name: "TransDate",
                table: "Transaction");

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Transaction",
                newName: "UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Transaction_UserId",
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
