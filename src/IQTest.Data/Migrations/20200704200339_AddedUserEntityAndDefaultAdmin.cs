using Microsoft.EntityFrameworkCore.Migrations;

namespace IQTest.Data.Migrations
{
    public partial class AddedUserEntityAndDefaultAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(maxLength: 100, nullable: false),
                    EmailAddress = table.Column<string>(maxLength: 100, nullable: false),
                    PasswordHash = table.Column<byte[]>(nullable: false),
                    PasswordSalt = table.Column<byte[]>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "EmailAddress", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 1, "admin@iqtest.com", new byte[] { 62, 192, 181, 24, 59, 191, 161, 174, 66, 53, 59, 125, 95, 149, 151, 0, 34, 250, 144, 112, 90, 251, 111, 174, 143, 10, 144, 7, 138, 100, 39, 192, 194, 155, 126, 32, 174, 196, 164, 69, 112, 70, 70, 251, 231, 235, 101, 174, 172, 158, 39, 19, 120, 66, 162, 117, 26, 96, 193, 35, 25, 178, 85, 152 }, new byte[] { 54, 90, 98, 108, 50, 118, 67, 80, 119, 51, 114, 79, 51, 54, 89, 73, 51, 121, 49, 106, 106, 68, 75, 106, 107, 89, 48, 48, 53, 89, 88, 107, 85, 53, 106, 100, 106, 114, 110, 53, 117, 107, 53, 50, 79, 48, 73, 115, 118, 74, 118, 65, 49, 65, 100, 53, 70, 65, 103, 57, 48, 85, 72, 110, 108, 74, 80, 120, 67, 97, 112, 55, 107, 106, 49, 78, 116, 113, 72, 69, 48, 84, 98, 80, 55, 101, 110, 105, 103, 78, 99, 105, 81, 78, 69, 106, 66, 48, 65, 72, 110, 68, 83, 51, 68, 66, 50, 119, 110, 106, 56, 54, 84, 83, 68, 67, 82, 101, 99, 55, 48, 54, 119, 116, 103, 66, 81, 70 }, "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
