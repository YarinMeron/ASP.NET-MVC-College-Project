using Microsoft.EntityFrameworkCore.Migrations;

namespace ShenkinStore.Migrations
{
    public partial class initial5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "User");

            migrationBuilder.DropColumn(
                name: "imgUrl",
                table: "User");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "User",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "ConfirmedPassword",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "userType",
                table: "User",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "ConfirmedPassword",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "User");

            migrationBuilder.DropColumn(
                name: "userType",
                table: "User");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "imgUrl",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");
        }
    }
}
