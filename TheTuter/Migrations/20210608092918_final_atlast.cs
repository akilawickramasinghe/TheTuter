using Microsoft.EntityFrameworkCore.Migrations;

namespace TheTuter.Migrations
{
    public partial class final_atlast : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "81602439-26b0-4e25-8ed5-0b938c11d1c8", "a785a628-f129-42dd-9b21-025e57a79367", "Visitor", "VISITOR" },
                    { "a60b9d70-0105-43c6-8db5-09e986f5281e", "3e5e7e66-df8e-49c6-b8cb-1f903847b2d2", "Teacher", "TEACHER" },
                    { "2960cb2a-132a-4321-82cd-77630e90a7c9", "e1ab531d-d555-4e30-b894-7c4ea91c6022", "Student", "STUDENT" },
                    { "f1087965-f05a-443d-a0b7-fe500bf2e14b", "6c930be7-c537-4517-9c30-390c2ccafe6e", "Administrator", "ADMINISTRATOR" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2960cb2a-132a-4321-82cd-77630e90a7c9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81602439-26b0-4e25-8ed5-0b938c11d1c8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a60b9d70-0105-43c6-8db5-09e986f5281e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f1087965-f05a-443d-a0b7-fe500bf2e14b");

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
    }
}
