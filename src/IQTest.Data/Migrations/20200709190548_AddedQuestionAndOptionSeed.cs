using Microsoft.EntityFrameworkCore.Migrations;

namespace IQTest.Data.Migrations
{
    public partial class AddedQuestionAndOptionSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsAnswer",
                value: false);

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 6,
                column: "IsAnswer",
                value: true);

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 7,
                column: "IsAnswer",
                value: false);

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 8,
                column: "IsAnswer",
                value: true);

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 13,
                column: "IsAnswer",
                value: true);

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 15,
                column: "IsAnswer",
                value: false);

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 27,
                column: "IsAnswer",
                value: false);

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 28,
                column: "IsAnswer",
                value: true);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Difficulty",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Difficulty",
                value: 1);

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Difficulty", "ImagePath", "Name" },
                values: new object[,]
                {
                    { 40, 1, "Resources/QuestionImages/q40.png", "Choose the missing figure." },
                    { 29, 1, "Resources/QuestionImages/q29.png", "Choose the missing figure." },
                    { 38, 1, "Resources/QuestionImages/q38.png", "Choose the missing figure." },
                    { 37, 1, "Resources/QuestionImages/q37.png", "Choose the missing figure." },
                    { 36, 1, "Resources/QuestionImages/q36.png", "Choose the missing figure." },
                    { 35, 1, "Resources/QuestionImages/q35.png", "Choose the missing figure." },
                    { 34, 1, "Resources/QuestionImages/q34.png", "Choose the missing figure." },
                    { 33, 1, "Resources/QuestionImages/q33.png", "Choose the missing figure." },
                    { 32, 1, "Resources/QuestionImages/q32.png", "Choose the missing figure." },
                    { 31, 1, "Resources/QuestionImages/q31.png", "Choose the missing figure." },
                    { 30, 1, "Resources/QuestionImages/q30.png", "Choose the missing figure." },
                    { 39, 1, "Resources/QuestionImages/q39.png", "Choose the missing figure." },
                    { 28, 1, "Resources/QuestionImages/q28.png", "Choose the missing figure." },
                    { 26, 1, "Resources/QuestionImages/q26.png", "Choose the missing figure." },
                    { 7, 1, "Resources/QuestionImages/q7.png", "Choose the missing figure." },
                    { 8, 1, "Resources/QuestionImages/q8.png", "Choose the missing figure." },
                    { 9, 1, "Resources/QuestionImages/q9.png", "Choose the missing figure." },
                    { 10, 1, "Resources/QuestionImages/q10.png", "Choose the missing figure." },
                    { 11, 1, "Resources/QuestionImages/q11.png", "Choose the missing figure." },
                    { 12, 1, "Resources/QuestionImages/q12.png", "Choose the missing figure." },
                    { 13, 1, "Resources/QuestionImages/q13.png", "Choose the missing figure." },
                    { 14, 1, "Resources/QuestionImages/q14.png", "Choose the missing figure." },
                    { 15, 1, "Resources/QuestionImages/q15.png", "Choose the missing figure." },
                    { 16, 1, "Resources/QuestionImages/q16.png", "Choose the missing figure." },
                    { 17, 1, "Resources/QuestionImages/q17.png", "Choose the missing figure." },
                    { 18, 1, "Resources/QuestionImages/q18.png", "Choose the missing figure." },
                    { 19, 1, "Resources/QuestionImages/q19.png", "Choose the missing figure." },
                    { 20, 1, "Resources/QuestionImages/q20.png", "Choose the missing figure." },
                    { 21, 1, "Resources/QuestionImages/q21.png", "Choose the missing figure." },
                    { 22, 1, "Resources/QuestionImages/q22.png", "Choose the missing figure." },
                    { 23, 1, "Resources/QuestionImages/q23.png", "Choose the missing figure." },
                    { 24, 1, "Resources/QuestionImages/q24.png", "Choose the missing figure." },
                    { 25, 1, "Resources/QuestionImages/q25.png", "Choose the missing figure." },
                    { 27, 1, "Resources/QuestionImages/q27.png", "Choose the missing figure." },
                    { 6, 1, "Resources/QuestionImages/q6.png", "Choose the missing figure." }
                });

            migrationBuilder.InsertData(
                table: "Options",
                columns: new[] { "Id", "ImagePath", "IsAnswer", "Name", "QuestionId" },
                values: new object[,]
                {
                    { 31, "Resources/QuestionOptionImages/q6o1.png", false, null, 6 },
                    { 164, "Resources/QuestionOptionImages/q28o2.png", false, null, 28 },
                    { 165, "Resources/QuestionOptionImages/q28o3.png", false, null, 28 },
                    { 166, "Resources/QuestionOptionImages/q28o4.png", false, null, 28 },
                    { 167, "Resources/QuestionOptionImages/q28o5.png", true, null, 28 },
                    { 168, "Resources/QuestionOptionImages/q28o6.png", false, null, 28 },
                    { 169, "Resources/QuestionOptionImages/q29o1.png", false, null, 29 },
                    { 170, "Resources/QuestionOptionImages/q29o2.png", true, null, 29 },
                    { 171, "Resources/QuestionOptionImages/q29o3.png", false, null, 29 },
                    { 172, "Resources/QuestionOptionImages/q29o4.png", false, null, 29 },
                    { 173, "Resources/QuestionOptionImages/q29o5.png", false, null, 29 },
                    { 163, "Resources/QuestionOptionImages/q28o1.png", false, null, 28 },
                    { 174, "Resources/QuestionOptionImages/q29o6.png", false, null, 29 },
                    { 176, "Resources/QuestionOptionImages/q30o2.png", false, null, 30 },
                    { 177, "Resources/QuestionOptionImages/q30o3.png", false, null, 30 },
                    { 178, "Resources/QuestionOptionImages/q30o4.png", false, null, 30 },
                    { 179, "Resources/QuestionOptionImages/q30o5.png", true, null, 30 },
                    { 180, "Resources/QuestionOptionImages/q30o6.png", false, null, 30 },
                    { 181, "Resources/QuestionOptionImages/q31o1.png", false, null, 31 },
                    { 182, "Resources/QuestionOptionImages/q31o2.png", false, null, 31 },
                    { 183, "Resources/QuestionOptionImages/q31o3.png", false, null, 31 },
                    { 184, "Resources/QuestionOptionImages/q31o4.png", false, null, 31 },
                    { 185, "Resources/QuestionOptionImages/q31o5.png", false, null, 31 },
                    { 175, "Resources/QuestionOptionImages/q30o1.png", false, null, 30 },
                    { 186, "Resources/QuestionOptionImages/q31o6.png", true, null, 31 },
                    { 162, "Resources/QuestionOptionImages/q27o6.png", false, null, 27 },
                    { 160, "Resources/QuestionOptionImages/q27o4.png", true, null, 27 },
                    { 138, "Resources/QuestionOptionImages/q23o6.png", false, null, 23 },
                    { 139, "Resources/QuestionOptionImages/q24o1.png", false, null, 24 },
                    { 140, "Resources/QuestionOptionImages/q24o2.png", false, null, 24 },
                    { 141, "Resources/QuestionOptionImages/q24o3.png", false, null, 24 },
                    { 142, "Resources/QuestionOptionImages/q24o4.png", false, null, 24 },
                    { 143, "Resources/QuestionOptionImages/q24o5.png", true, null, 24 },
                    { 144, "Resources/QuestionOptionImages/q24o6.png", false, null, 24 },
                    { 145, "Resources/QuestionOptionImages/q25o1.png", false, null, 25 },
                    { 146, "Resources/QuestionOptionImages/q25o2.png", false, null, 25 },
                    { 147, "Resources/QuestionOptionImages/q25o3.png", false, null, 25 },
                    { 161, "Resources/QuestionOptionImages/q27o5.png", false, null, 27 },
                    { 148, "Resources/QuestionOptionImages/q25o4.png", false, null, 25 },
                    { 150, "Resources/QuestionOptionImages/q25o6.png", false, null, 25 },
                    { 151, "Resources/QuestionOptionImages/q26o1.png", false, null, 26 },
                    { 152, "Resources/QuestionOptionImages/q26o2.png", false, null, 26 },
                    { 153, "Resources/QuestionOptionImages/q26o3.png", false, null, 26 },
                    { 154, "Resources/QuestionOptionImages/q26o4.png", true, null, 26 },
                    { 155, "Resources/QuestionOptionImages/q26o5.png", false, null, 26 },
                    { 156, "Resources/QuestionOptionImages/q26o6.png", false, null, 26 },
                    { 157, "Resources/QuestionOptionImages/q27o1.png", false, null, 27 },
                    { 158, "Resources/QuestionOptionImages/q27o2.png", false, null, 27 },
                    { 159, "Resources/QuestionOptionImages/q27o3.png", false, null, 27 },
                    { 149, "Resources/QuestionOptionImages/q25o5.png", true, null, 25 },
                    { 187, "Resources/QuestionOptionImages/q32o1.png", false, null, 32 },
                    { 188, "Resources/QuestionOptionImages/q32o2.png", false, null, 32 },
                    { 189, "Resources/QuestionOptionImages/q32o3.png", true, null, 32 },
                    { 217, "Resources/QuestionOptionImages/q37o1.png", false, null, 37 },
                    { 218, "Resources/QuestionOptionImages/q37o2.png", false, null, 37 },
                    { 219, "Resources/QuestionOptionImages/q37o3.png", false, null, 37 },
                    { 220, "Resources/QuestionOptionImages/q37o4.png", true, null, 37 },
                    { 221, "Resources/QuestionOptionImages/q37o5.png", false, null, 37 },
                    { 222, "Resources/QuestionOptionImages/q37o6.png", false, null, 37 },
                    { 223, "Resources/QuestionOptionImages/q38o1.png", false, null, 38 },
                    { 224, "Resources/QuestionOptionImages/q38o2.png", true, null, 38 },
                    { 225, "Resources/QuestionOptionImages/q38o3.png", false, null, 38 },
                    { 226, "Resources/QuestionOptionImages/q38o4.png", false, null, 38 },
                    { 216, "Resources/QuestionOptionImages/q36o6.png", true, null, 36 },
                    { 227, "Resources/QuestionOptionImages/q38o5.png", false, null, 38 },
                    { 229, "Resources/QuestionOptionImages/q39o1.png", false, null, 39 },
                    { 230, "Resources/QuestionOptionImages/q39o2.png", false, null, 39 },
                    { 231, "Resources/QuestionOptionImages/q39o3.png", true, null, 39 },
                    { 232, "Resources/QuestionOptionImages/q39o4.png", false, null, 39 },
                    { 233, "Resources/QuestionOptionImages/q39o5.png", false, null, 39 },
                    { 234, "Resources/QuestionOptionImages/q39o6.png", false, null, 39 },
                    { 235, "Resources/QuestionOptionImages/q40o1.png", false, null, 40 },
                    { 236, "Resources/QuestionOptionImages/q40o2.png", false, null, 40 },
                    { 237, "Resources/QuestionOptionImages/q40o3.png", false, null, 40 },
                    { 238, "Resources/QuestionOptionImages/q40o4.png", false, null, 40 },
                    { 228, "Resources/QuestionOptionImages/q38o6.png", false, null, 38 },
                    { 215, "Resources/QuestionOptionImages/q36o5.png", false, null, 36 },
                    { 214, "Resources/QuestionOptionImages/q36o4.png", false, null, 36 },
                    { 213, "Resources/QuestionOptionImages/q36o3.png", false, null, 36 },
                    { 190, "Resources/QuestionOptionImages/q32o4.png", false, null, 32 },
                    { 191, "Resources/QuestionOptionImages/q32o5.png", false, null, 32 },
                    { 192, "Resources/QuestionOptionImages/q32o6.png", false, null, 32 },
                    { 193, "Resources/QuestionOptionImages/q33o1.png", false, null, 33 },
                    { 194, "Resources/QuestionOptionImages/q33o2.png", true, null, 33 },
                    { 195, "Resources/QuestionOptionImages/q33o3.png", false, null, 33 },
                    { 196, "Resources/QuestionOptionImages/q33o4.png", false, null, 33 },
                    { 197, "Resources/QuestionOptionImages/q33o5.png", false, null, 33 },
                    { 198, "Resources/QuestionOptionImages/q33o6.png", false, null, 33 },
                    { 199, "Resources/QuestionOptionImages/q34o1.png", false, null, 34 },
                    { 200, "Resources/QuestionOptionImages/q34o2.png", false, null, 34 },
                    { 201, "Resources/QuestionOptionImages/q34o3.png", true, null, 34 },
                    { 202, "Resources/QuestionOptionImages/q34o4.png", false, null, 34 },
                    { 203, "Resources/QuestionOptionImages/q34o5.png", false, null, 34 },
                    { 204, "Resources/QuestionOptionImages/q34o6.png", false, null, 34 },
                    { 205, "Resources/QuestionOptionImages/q35o1.png", false, null, 35 },
                    { 206, "Resources/QuestionOptionImages/q35o2.png", false, null, 35 },
                    { 207, "Resources/QuestionOptionImages/q35o3.png", false, null, 35 },
                    { 208, "Resources/QuestionOptionImages/q35o4.png", false, null, 35 },
                    { 209, "Resources/QuestionOptionImages/q35o5.png", false, null, 35 },
                    { 210, "Resources/QuestionOptionImages/q35o6.png", true, null, 35 },
                    { 211, "Resources/QuestionOptionImages/q36o1.png", false, null, 36 },
                    { 212, "Resources/QuestionOptionImages/q36o2.png", false, null, 36 },
                    { 137, "Resources/QuestionOptionImages/q23o5.png", false, null, 23 },
                    { 136, "Resources/QuestionOptionImages/q23o4.png", false, null, 23 },
                    { 135, "Resources/QuestionOptionImages/q23o3.png", true, null, 23 },
                    { 134, "Resources/QuestionOptionImages/q23o2.png", false, null, 23 },
                    { 59, "Resources/QuestionOptionImages/q10o5.png", false, null, 10 },
                    { 60, "Resources/QuestionOptionImages/q10o6.png", true, null, 10 },
                    { 61, "Resources/QuestionOptionImages/q11o1.png", false, null, 11 },
                    { 62, "Resources/QuestionOptionImages/q11o2.png", false, null, 11 },
                    { 63, "Resources/QuestionOptionImages/q11o3.png", false, null, 11 },
                    { 64, "Resources/QuestionOptionImages/q11o4.png", false, null, 11 },
                    { 65, "Resources/QuestionOptionImages/q11o5.png", false, null, 11 },
                    { 66, "Resources/QuestionOptionImages/q11o6.png", true, null, 11 },
                    { 67, "Resources/QuestionOptionImages/q12o1.png", true, null, 12 },
                    { 68, "Resources/QuestionOptionImages/q12o2.png", false, null, 12 },
                    { 58, "Resources/QuestionOptionImages/q10o4.png", false, null, 10 },
                    { 69, "Resources/QuestionOptionImages/q12o3.png", false, null, 12 },
                    { 71, "Resources/QuestionOptionImages/q12o5.png", false, null, 12 },
                    { 72, "Resources/QuestionOptionImages/q12o6.png", false, null, 12 },
                    { 73, "Resources/QuestionOptionImages/q13o1.png", false, null, 13 },
                    { 74, "Resources/QuestionOptionImages/q13o2.png", false, null, 13 },
                    { 75, "Resources/QuestionOptionImages/q13o3.png", false, null, 13 },
                    { 76, "Resources/QuestionOptionImages/q13o4.png", false, null, 13 },
                    { 77, "Resources/QuestionOptionImages/q13o5.png", true, null, 13 },
                    { 78, "Resources/QuestionOptionImages/q13o6.png", false, null, 13 },
                    { 79, "Resources/QuestionOptionImages/q14o1.png", false, null, 14 },
                    { 80, "Resources/QuestionOptionImages/q14o2.png", false, null, 14 },
                    { 70, "Resources/QuestionOptionImages/q12o4.png", false, null, 12 },
                    { 57, "Resources/QuestionOptionImages/q10o3.png", false, null, 10 },
                    { 56, "Resources/QuestionOptionImages/q10o2.png", false, null, 10 },
                    { 55, "Resources/QuestionOptionImages/q10o1.png", false, null, 10 },
                    { 32, "Resources/QuestionOptionImages/q6o2.png", true, null, 6 },
                    { 33, "Resources/QuestionOptionImages/q6o3.png", false, null, 6 },
                    { 34, "Resources/QuestionOptionImages/q6o4.png", false, null, 6 },
                    { 35, "Resources/QuestionOptionImages/q6o5.png", false, null, 6 },
                    { 36, "Resources/QuestionOptionImages/q6o6.png", false, null, 6 },
                    { 37, "Resources/QuestionOptionImages/q7o1.png", false, null, 7 },
                    { 38, "Resources/QuestionOptionImages/q7o2.png", false, null, 7 },
                    { 39, "Resources/QuestionOptionImages/q7o3.png", false, null, 7 },
                    { 40, "Resources/QuestionOptionImages/q7o4.png", false, null, 7 },
                    { 41, "Resources/QuestionOptionImages/q7o5.png", false, null, 7 },
                    { 42, "Resources/QuestionOptionImages/q7o6.png", true, null, 7 },
                    { 43, "Resources/QuestionOptionImages/q8o1.png", true, null, 8 },
                    { 44, "Resources/QuestionOptionImages/q8o2.png", false, null, 8 },
                    { 45, "Resources/QuestionOptionImages/q8o3.png", false, null, 8 },
                    { 46, "Resources/QuestionOptionImages/q8o4.png", false, null, 8 },
                    { 47, "Resources/QuestionOptionImages/q8o5.png", false, null, 8 },
                    { 48, "Resources/QuestionOptionImages/q8o6.png", false, null, 8 },
                    { 49, "Resources/QuestionOptionImages/q9o1.png", false, null, 9 },
                    { 50, "Resources/QuestionOptionImages/q9o2.png", false, null, 9 },
                    { 51, "Resources/QuestionOptionImages/q9o3.png", false, null, 9 },
                    { 52, "Resources/QuestionOptionImages/q9o4.png", true, null, 9 },
                    { 53, "Resources/QuestionOptionImages/q9o5.png", false, null, 9 },
                    { 54, "Resources/QuestionOptionImages/q9o6.png", false, null, 9 },
                    { 81, "Resources/QuestionOptionImages/q14o3.png", false, null, 14 },
                    { 239, "Resources/QuestionOptionImages/q40o5.png", false, null, 40 },
                    { 82, "Resources/QuestionOptionImages/q14o4.png", true, null, 14 },
                    { 84, "Resources/QuestionOptionImages/q14o6.png", false, null, 14 },
                    { 112, "Resources/QuestionOptionImages/q19o4.png", true, null, 19 },
                    { 113, "Resources/QuestionOptionImages/q19o5.png", false, null, 19 },
                    { 114, "Resources/QuestionOptionImages/q19o6.png", false, null, 19 },
                    { 115, "Resources/QuestionOptionImages/q20o1.png", false, null, 20 },
                    { 116, "Resources/QuestionOptionImages/q20o2.png", false, null, 20 },
                    { 117, "Resources/QuestionOptionImages/q20o3.png", false, null, 20 },
                    { 118, "Resources/QuestionOptionImages/q20o4.png", true, null, 20 },
                    { 119, "Resources/QuestionOptionImages/q20o5.png", false, null, 20 },
                    { 120, "Resources/QuestionOptionImages/q20o6.png", false, null, 20 },
                    { 121, "Resources/QuestionOptionImages/q21o1.png", false, null, 21 },
                    { 111, "Resources/QuestionOptionImages/q19o3.png", false, null, 19 },
                    { 122, "Resources/QuestionOptionImages/q21o2.png", true, null, 21 },
                    { 124, "Resources/QuestionOptionImages/q21o4.png", false, null, 21 },
                    { 125, "Resources/QuestionOptionImages/q21o5.png", false, null, 21 },
                    { 126, "Resources/QuestionOptionImages/q21o6.png", false, null, 21 },
                    { 127, "Resources/QuestionOptionImages/q22o1.png", false, null, 22 },
                    { 128, "Resources/QuestionOptionImages/q22o2.png", false, null, 22 },
                    { 129, "Resources/QuestionOptionImages/q22o3.png", false, null, 22 },
                    { 130, "Resources/QuestionOptionImages/q22o4.png", false, null, 22 },
                    { 131, "Resources/QuestionOptionImages/q22o5.png", true, null, 22 },
                    { 132, "Resources/QuestionOptionImages/q22o6.png", false, null, 22 },
                    { 133, "Resources/QuestionOptionImages/q23o1.png", false, null, 23 },
                    { 123, "Resources/QuestionOptionImages/q21o3.png", false, null, 21 },
                    { 110, "Resources/QuestionOptionImages/q19o2.png", false, null, 19 },
                    { 109, "Resources/QuestionOptionImages/q19o1.png", false, null, 19 },
                    { 108, "Resources/QuestionOptionImages/q18o6.png", false, null, 18 },
                    { 85, "Resources/QuestionOptionImages/q15o1.png", false, null, 15 },
                    { 86, "Resources/QuestionOptionImages/q15o2.png", true, null, 15 },
                    { 87, "Resources/QuestionOptionImages/q15o3.png", false, null, 15 },
                    { 88, "Resources/QuestionOptionImages/q15o4.png", false, null, 15 },
                    { 89, "Resources/QuestionOptionImages/q15o5.png", false, null, 15 },
                    { 90, "Resources/QuestionOptionImages/q15o6.png", false, null, 15 },
                    { 91, "Resources/QuestionOptionImages/q16o1.png", false, null, 16 },
                    { 92, "Resources/QuestionOptionImages/q16o2.png", false, null, 16 },
                    { 93, "Resources/QuestionOptionImages/q16o3.png", false, null, 16 },
                    { 94, "Resources/QuestionOptionImages/q16o4.png", false, null, 16 },
                    { 95, "Resources/QuestionOptionImages/q16o5.png", true, null, 16 },
                    { 96, "Resources/QuestionOptionImages/q16o6.png", false, null, 16 },
                    { 97, "Resources/QuestionOptionImages/q17o1.png", false, null, 17 },
                    { 98, "Resources/QuestionOptionImages/q17o2.png", false, null, 17 },
                    { 99, "Resources/QuestionOptionImages/q17o3.png", false, null, 17 },
                    { 100, "Resources/QuestionOptionImages/q17o4.png", true, null, 17 },
                    { 101, "Resources/QuestionOptionImages/q17o5.png", false, null, 17 },
                    { 102, "Resources/QuestionOptionImages/q17o6.png", false, null, 17 },
                    { 103, "Resources/QuestionOptionImages/q18o1.png", false, null, 18 },
                    { 104, "Resources/QuestionOptionImages/q18o2.png", false, null, 18 },
                    { 105, "Resources/QuestionOptionImages/q18o3.png", false, null, 18 },
                    { 106, "Resources/QuestionOptionImages/q18o4.png", true, null, 18 },
                    { 107, "Resources/QuestionOptionImages/q18o5.png", false, null, 18 },
                    { 83, "Resources/QuestionOptionImages/q14o5.png", false, null, 14 },
                    { 240, "Resources/QuestionOptionImages/q40o6.png", true, null, 40 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsAnswer",
                value: true);

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 6,
                column: "IsAnswer",
                value: false);

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 7,
                column: "IsAnswer",
                value: true);

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 8,
                column: "IsAnswer",
                value: false);

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 13,
                column: "IsAnswer",
                value: false);

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 15,
                column: "IsAnswer",
                value: true);

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 27,
                column: "IsAnswer",
                value: true);

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 28,
                column: "IsAnswer",
                value: false);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Difficulty",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Difficulty",
                value: 2);
        }
    }
}
