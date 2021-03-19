using Microsoft.EntityFrameworkCore.Migrations;

namespace TheTuter.Migrations
{
    public partial class reinitial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "24ae9a4b-8b41-46b6-8422-400ae86f23a3");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "45b9141c-6b7f-4461-bc30-5d288b865dea");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c5058b64-cc05-4e55-869b-885160e93292");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d4ac5368-c4c1-4d04-82a2-9cbf59012fbd");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Students",
                nullable: true);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a456ddc3-31e6-4846-90fe-173c4b599de4", "fd3354a1-d79f-4720-9b06-c369ae376719", "Visitor", "VISITOR" },
                    { "be04c6f5-69aa-4965-b00f-576e9d61555f", "a3051d15-7a45-4e3f-b4b6-81d9b3cf7fd6", "Teacher", "TEACHER" },
                    { "e4fc1209-a5f7-4d79-ae99-c054b75853f5", "9ffc3d22-16ba-4e0e-a742-d21ac7acf085", "Student", "STUDENT" },
                    { "84e13d3a-3166-4392-b1a1-97363e0375c4", "cea066dd-3ab7-4e5e-b93d-c9da788034fc", "Administrator", "ADMINISTRATOR" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "84e13d3a-3166-4392-b1a1-97363e0375c4");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "a456ddc3-31e6-4846-90fe-173c4b599de4");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "be04c6f5-69aa-4965-b00f-576e9d61555f");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "e4fc1209-a5f7-4d79-ae99-c054b75853f5");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Students");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "24ae9a4b-8b41-46b6-8422-400ae86f23a3", "99941bd2-6d97-46d3-a5e4-dce03d2a5a7b", "Visitor", "VISITOR" },
                    { "d4ac5368-c4c1-4d04-82a2-9cbf59012fbd", "4e0d9df3-af3a-4cd8-9882-692d17d74c47", "Teacher", "TEACHER" },
                    { "c5058b64-cc05-4e55-869b-885160e93292", "73dce6f8-75d5-4606-81cf-2fa035fc8203", "Student", "STUDENT" },
                    { "45b9141c-6b7f-4461-bc30-5d288b865dea", "47bfe8cb-beaf-448a-93fb-975587460d58", "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
