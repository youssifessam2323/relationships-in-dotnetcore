using Microsoft.EntityFrameworkCore.Migrations;

namespace Relationships_in_efcore.Migrations
{
    public partial class tryingoneToManySelfReferencing2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ManagerId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Comments");

            migrationBuilder.AddColumn<string>(
                name: "comment_text",
                table: "Comments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "comment_text",
                table: "Comments");

            migrationBuilder.AddColumn<int>(
                name: "ManagerId",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
