using Microsoft.EntityFrameworkCore.Migrations;

namespace TheTuter.Migrations
{
    public partial class reinitial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "467c1e91-55d3-4e44-a9fd-5cbf16a4b6ca");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "872596ae-66a6-4dcb-84cf-41d7169cf099");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "9bdc88a2-a35b-4b36-98e8-36362a0e9325");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "9e2ab56e-04e7-4c5b-a3a3-e690c0bc69e0");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9bdc88a2-a35b-4b36-98e8-36362a0e9325", "499b44f5-976a-4fb4-937f-958f3ced59ff", "Visitor", "VISITOR" },
                    { "9e2ab56e-04e7-4c5b-a3a3-e690c0bc69e0", "af012e3f-7c5e-412b-919b-027f62436a59", "Teacher", "TEACHER" },
                    { "467c1e91-55d3-4e44-a9fd-5cbf16a4b6ca", "f7528fe8-2b1e-4cf2-a29a-f08d3d4a73b9", "Student", "STUDENT" },
                    { "872596ae-66a6-4dcb-84cf-41d7169cf099", "f5c8de18-a876-4b8d-8228-146fa5c35cf9", "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
