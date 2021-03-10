using Microsoft.EntityFrameworkCore.Migrations;

namespace TheTuter.Migrations
{
    public partial class RolesAdded_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "31271f0d-73bc-4a42-be2d-57905b022f28");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "5729f3d0-def8-44c7-bb91-a093ee9bf4c5");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "9e4075bb-6692-4d47-b2f3-f6d3d94e66da");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "b32c5d4e-aee9-436b-b8ac-113d472a5dc3");

            migrationBuilder.AddColumn<bool>(
                name: "IsStudent",
                table: "Users",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2944ca19-5f2c-44f0-a978-c590f50356f3", "361e147b-4951-4d52-bca9-23a4ece76c28", "Visitor", "VISITOR" },
                    { "a35cf118-b5bd-4897-961f-7209b1ea60d9", "e34dc3e3-4553-4f96-b554-96e57683d19b", "Teacher", "TEACHER" },
                    { "2abfc9dd-250d-41d3-b2d6-176590c58f0c", "48c0ff67-a49c-4bed-87fa-32576c2a9f61", "Student", "STUDENT" },
                    { "e9b6b99d-add0-49fe-aba6-cf1ba2fa5496", "d34ed73e-971b-4ddc-b40b-2a5fc3634c8b", "Administrator", "ADMINISTRATOR" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2944ca19-5f2c-44f0-a978-c590f50356f3");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2abfc9dd-250d-41d3-b2d6-176590c58f0c");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "a35cf118-b5bd-4897-961f-7209b1ea60d9");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "e9b6b99d-add0-49fe-aba6-cf1ba2fa5496");

            migrationBuilder.DropColumn(
                name: "IsStudent",
                table: "Users");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "31271f0d-73bc-4a42-be2d-57905b022f28", "353944b4-dcf4-49bd-84c4-f9d0949803e9", "Visitor", "VISITOR" },
                    { "b32c5d4e-aee9-436b-b8ac-113d472a5dc3", "caec4df3-722a-4aed-b3fa-c9789b19ae79", "Teacher", "TEACHER" },
                    { "9e4075bb-6692-4d47-b2f3-f6d3d94e66da", "3e0fc724-17a8-40f4-951d-abd6e91590d9", "Student", "STUDENT" },
                    { "5729f3d0-def8-44c7-bb91-a093ee9bf4c5", "2592a89e-4e64-4d6a-a934-aa4a52534ed7", "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
