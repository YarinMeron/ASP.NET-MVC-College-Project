using Microsoft.EntityFrameworkCore.Migrations;

namespace ShenkinStore.Migrations
{
    public partial class comeon12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "inCart",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "sold",
                table: "Products");
        }
    }
}
