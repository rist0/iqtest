using Microsoft.EntityFrameworkCore.Migrations;

namespace IQTest.Data.Migrations
{
    public partial class AddedDifficulty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Difficulty",
                table: "Questions",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Difficulty",
                table: "Questions");
        }
    }
}
