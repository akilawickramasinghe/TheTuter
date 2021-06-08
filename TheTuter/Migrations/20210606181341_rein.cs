using Microsoft.EntityFrameworkCore.Migrations;

namespace TheTuter.Migrations
{
    public partial class rein : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c5a8c12-cdf2-40ef-b89f-f5238e5490f3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "437367a4-c255-4ddd-83d6-b860f8ac35fd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "533f9cc8-b784-4fc2-955f-ab286e14f8a7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d2de4e54-4846-46e8-90fc-1a38b394e62c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "28a94cff-aeb8-4384-a510-570424a41781", "9c401255-f2e1-4644-bc4f-4f71c0e1d0b6", "Administrator", "ADMINISTRATOR" },
                    { "586a6993-985b-4857-9309-b695c36eb1ef", "fcebbb23-1daf-45c3-8fe2-ce71279820d7", "Visitor", "VISITOR" },
                    { "1ea2a21d-af10-45ef-a4eb-8cc7c81cd379", "b9178572-9411-4c49-9779-324d7840e541", "Teacher", "TEACHER" },
                    { "080013c4-a94a-4fed-83b4-f42e68637462", "1426fd9a-557b-4fbf-99a9-f44e6d3a183b", "Student", "STUDENT" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "080013c4-a94a-4fed-83b4-f42e68637462");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ea2a21d-af10-45ef-a4eb-8cc7c81cd379");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "28a94cff-aeb8-4384-a510-570424a41781");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "586a6993-985b-4857-9309-b695c36eb1ef");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d2de4e54-4846-46e8-90fc-1a38b394e62c", "d43ce294-b5dc-4b05-bbb0-64bc60cb3a65", "Administrator", "ADMINISTRATOR" },
                    { "437367a4-c255-4ddd-83d6-b860f8ac35fd", "138199a4-a8f2-4509-80f3-03a67ec5094f", "Visitor", "VISITOR" },
                    { "533f9cc8-b784-4fc2-955f-ab286e14f8a7", "64f7da82-6589-45e9-b704-a59cfb2f5f78", "Teacher", "TEACHER" },
                    { "0c5a8c12-cdf2-40ef-b89f-f5238e5490f3", "270e990e-f16d-4edf-a51d-2909687bc7f4", "Student", "STUDENT" }
                });
        }
    }
}
