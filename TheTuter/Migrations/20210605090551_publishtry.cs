using Microsoft.EntityFrameworkCore.Migrations;

namespace TheTuter.Migrations
{
    public partial class publishtry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26b6244f-dfb8-4e26-b444-98911cbe361e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65a63c3a-71fc-4498-b51d-31d0d7153a65");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da77dc76-f106-4cdb-bee3-bbfdfc1da284");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff6bf0d8-2293-48a2-82bb-48f7298a52b3");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "26b6244f-dfb8-4e26-b444-98911cbe361e", "8769ba36-4512-43c6-990a-6c5eceef7c08", "Visitor", "VISITOR" },
                    { "da77dc76-f106-4cdb-bee3-bbfdfc1da284", "ce0b4f0c-1f4d-4a05-a519-e79dec23d4c0", "Teacher", "TEACHER" },
                    { "65a63c3a-71fc-4498-b51d-31d0d7153a65", "13073815-93d7-4f07-8ffd-abbef9b69736", "Student", "STUDENT" },
                    { "ff6bf0d8-2293-48a2-82bb-48f7298a52b3", "82c65b28-8fe5-4e22-854f-359e6b0509b7", "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
