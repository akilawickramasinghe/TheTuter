using Microsoft.EntityFrameworkCore.Migrations;

namespace TheTuter.Migrations
{
    public partial class publishtry1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "089442a2-befd-4d55-a9ed-3016d11409c6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "219ecb8c-8404-47ae-b57a-c5047b9dc360");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "82bec2bf-360f-420f-896e-87a91dea6e40");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "98ca5d76-847c-4084-8692-8c5c690df3b2");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "219ecb8c-8404-47ae-b57a-c5047b9dc360", "071bfb87-cf1f-4387-b16e-25af2e6c47a4", "Visitor", "VISITOR" },
                    { "089442a2-befd-4d55-a9ed-3016d11409c6", "2d0d696e-e839-4ce7-a8c6-199ac7507b06", "Teacher", "TEACHER" },
                    { "82bec2bf-360f-420f-896e-87a91dea6e40", "3b4eec47-22cf-489a-8ee8-ef4af5008a20", "Student", "STUDENT" },
                    { "98ca5d76-847c-4084-8692-8c5c690df3b2", "8c4e1a46-3538-42da-a41b-99ce56b47f02", "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
