using Microsoft.EntityFrameworkCore.Migrations;

namespace TheTuter.Migrations
{
    public partial class reinitialfinal1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b675902-fe3e-47a1-87a2-4c711a9a0f76");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b4e8ca3-6166-4d17-905b-20926b710ebb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d39a1bce-9ca1-4318-86d2-f24d2ee9e81d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e98abe99-91dc-470b-b43b-a1fd7db37c19");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cb4a6822-f4d7-4d28-b8d3-3587383cb69c", "384b3101-6107-4559-903f-60fea32131e2", "Visitor", "VISITOR" },
                    { "3e0e17e2-7587-4093-8cb2-d723fd4740b4", "10b93c43-61ac-43e3-b329-fa1936a2e3f5", "Teacher", "TEACHER" },
                    { "fe1433e2-c761-4fef-8649-fb12f9b613ac", "cd3a8f74-7c9d-4883-a90d-d02f025c5e10", "Student", "STUDENT" },
                    { "d4102ca0-1a5e-4c91-943f-d953f1416696", "a0033661-af46-49a2-a6c7-b74c34a9c5ee", "Administrator", "ADMINISTRATOR" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e0e17e2-7587-4093-8cb2-d723fd4740b4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb4a6822-f4d7-4d28-b8d3-3587383cb69c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4102ca0-1a5e-4c91-943f-d953f1416696");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe1433e2-c761-4fef-8649-fb12f9b613ac");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2b675902-fe3e-47a1-87a2-4c711a9a0f76", "0532478a-9144-44aa-8c3d-f1db2e31a8a0", "Visitor", "VISITOR" },
                    { "d39a1bce-9ca1-4318-86d2-f24d2ee9e81d", "30148a56-056b-4f21-b238-02499eb16836", "Teacher", "TEACHER" },
                    { "4b4e8ca3-6166-4d17-905b-20926b710ebb", "4017cafa-6361-479c-9c8d-1768fbf266c1", "Student", "STUDENT" },
                    { "e98abe99-91dc-470b-b43b-a1fd7db37c19", "8eae5d0d-47e3-4911-acf5-8bcc5eb602b0", "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
