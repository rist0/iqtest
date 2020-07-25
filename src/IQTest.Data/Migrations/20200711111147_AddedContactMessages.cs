using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IQTest.Data.Migrations
{
    public partial class AddedContactMessages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactMessages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: false),
                    EmailAddress = table.Column<string>(nullable: false),
                    Subject = table.Column<string>(nullable: false),
                    Message = table.Column<string>(maxLength: 200, nullable: false),
                    DateReceived = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactMessages", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactMessages");
        }
    }
}
