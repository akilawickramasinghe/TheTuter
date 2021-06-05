using Microsoft.EntityFrameworkCore.Migrations;

namespace TheTuter.Migrations
{
    public partial class reinitialfinal2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "c1efd3c8-9d99-4375-8044-bb38eeddb1ed", "0fb2fb3b-f381-471b-a723-70c6c8c303f6", "Visitor", "VISITOR" },
                    { "18c39dd5-02d1-45a1-b7cc-38aaae898d2f", "aaa23f37-ea17-4191-b21d-a1b9a18437c7", "Teacher", "TEACHER" },
                    { "94ae98a4-43ec-441f-883b-614797b7df3e", "b7ecc71c-7254-446f-ba1a-10bbf4ad039a", "Student", "STUDENT" },
                    { "941bc30e-d0e9-4909-a380-e419a6eda658", "dfcd0874-07fa-470f-91bf-dcb3a39287c2", "Administrator", "ADMINISTRATOR" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18c39dd5-02d1-45a1-b7cc-38aaae898d2f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "941bc30e-d0e9-4909-a380-e419a6eda658");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94ae98a4-43ec-441f-883b-614797b7df3e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c1efd3c8-9d99-4375-8044-bb38eeddb1ed");

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
    }
}
