using Microsoft.EntityFrameworkCore.Migrations;

namespace TheTuter.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "774100cd-1ff4-43ba-a8c7-802c2c898d9a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6e80e26-57f1-45bc-be86-705ad31d545f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e599506d-db93-4548-a33f-3530c574b6cb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffb7cec5-a5b1-47f5-9347-18a0a300bded");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "b6e80e26-57f1-45bc-be86-705ad31d545f", "86ce49de-ed75-4a04-8969-8814fca2b108", "Visitor", "VISITOR" },
                    { "e599506d-db93-4548-a33f-3530c574b6cb", "332510f6-2abb-4a4f-ae2c-972c033d00bd", "Teacher", "TEACHER" },
                    { "774100cd-1ff4-43ba-a8c7-802c2c898d9a", "8d88862f-c0e8-4fc4-b45a-64a24d24a75e", "Student", "STUDENT" },
                    { "ffb7cec5-a5b1-47f5-9347-18a0a300bded", "796e3ae3-28d5-4c33-9a68-7ca2a24a8cf3", "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
