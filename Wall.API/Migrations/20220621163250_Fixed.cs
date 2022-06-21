using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Wall.API.Migrations
{
    public partial class Fixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BaseModels",
                table: "BaseModels");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "BaseModels");

            migrationBuilder.RenameTable(
                name: "BaseModels",
                newName: "Posts");

            migrationBuilder.AlterColumn<string>(
                name: "TextContent",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MoodState",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Posts",
                table: "Posts",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Posts",
                table: "Posts");

            migrationBuilder.RenameTable(
                name: "Posts",
                newName: "BaseModels");

            migrationBuilder.AlterColumn<string>(
                name: "TextContent",
                table: "BaseModels",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "MoodState",
                table: "BaseModels",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "BaseModels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BaseModels",
                table: "BaseModels",
                column: "Id");
        }
    }
}
