using Microsoft.EntityFrameworkCore.Migrations;

namespace IQTest.Data.Migrations
{
    public partial class AddedQuestionSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Difficulty", "ImagePath", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Resources/QuestionImages/q1.png", "Choose the missing figure." },
                    { 2, 1, "Resources/QuestionImages/q2.png", "Choose the missing figure." },
                    { 3, 1, "Resources/QuestionImages/q3.png", "Choose the missing figure." },
                    { 4, 2, "Resources/QuestionImages/q4.png", "Choose the missing figure." },
                    { 5, 2, "Resources/QuestionImages/q5.png", "Choose the missing figure." }
                });

            migrationBuilder.InsertData(
                table: "Options",
                columns: new[] { "Id", "ImagePath", "IsAnswer", "Name", "QuestionId" },
                values: new object[,]
                {
                    { 1, "Resources/QuestionOptionImages/q1o1.png", false, null, 1 },
                    { 28, "Resources/QuestionOptionImages/q5o4.png", false, null, 5 },
                    { 27, "Resources/QuestionOptionImages/q5o3.png", true, null, 5 },
                    { 26, "Resources/QuestionOptionImages/q5o2.png", false, null, 5 },
                    { 25, "Resources/QuestionOptionImages/q5o1.png", false, null, 5 },
                    { 24, "Resources/QuestionOptionImages/q4o6.png", false, null, 4 },
                    { 23, "Resources/QuestionOptionImages/q4o5.png", false, null, 4 },
                    { 22, "Resources/QuestionOptionImages/q4o4.png", false, null, 4 },
                    { 21, "Resources/QuestionOptionImages/q4o3.png", true, null, 4 },
                    { 20, "Resources/QuestionOptionImages/q4o2.png", false, null, 4 },
                    { 19, "Resources/QuestionOptionImages/q4o1.png", false, null, 4 },
                    { 18, "Resources/QuestionOptionImages/q3o6.png", false, null, 3 },
                    { 17, "Resources/QuestionOptionImages/q3o5.png", false, null, 3 },
                    { 16, "Resources/QuestionOptionImages/q3o4.png", false, null, 3 },
                    { 15, "Resources/QuestionOptionImages/q3o3.png", true, null, 3 },
                    { 14, "Resources/QuestionOptionImages/q3o2.png", false, null, 3 },
                    { 13, "Resources/QuestionOptionImages/q3o1.png", false, null, 3 },
                    { 12, "Resources/QuestionOptionImages/q2o6.png", false, null, 2 },
                    { 11, "Resources/QuestionOptionImages/q2o5.png", false, null, 2 },
                    { 10, "Resources/QuestionOptionImages/q2o4.png", false, null, 2 },
                    { 9, "Resources/QuestionOptionImages/q2o3.png", false, null, 2 },
                    { 8, "Resources/QuestionOptionImages/q2o2.png", false, null, 2 },
                    { 7, "Resources/QuestionOptionImages/q2o1.png", true, null, 2 },
                    { 6, "Resources/QuestionOptionImages/q1o6.png", false, null, 1 },
                    { 5, "Resources/QuestionOptionImages/q1o5.png", false, null, 1 },
                    { 4, "Resources/QuestionOptionImages/q1o4.png", false, null, 1 },
                    { 3, "Resources/QuestionOptionImages/q1o3.png", true, null, 1 },
                    { 2, "Resources/QuestionOptionImages/q1o2.png", false, null, 1 },
                    { 29, "Resources/QuestionOptionImages/q5o5.png", false, null, 5 },
                    { 30, "Resources/QuestionOptionImages/q5o6.png", false, null, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
