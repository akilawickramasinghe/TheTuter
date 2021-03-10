using Microsoft.EntityFrameworkCore.Migrations;

namespace TheTuter.Migrations
{
    public partial class RolesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1da84882-ca71-458f-aa7c-8a8c1d83406a");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "aba63205-098c-4594-8aeb-ee8b70371512");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "df4b2546-6818-4e22-87e6-671ded14f610");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f9ccc546-3e40-49e9-92f8-d6f9e540a6fe");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1da84882-ca71-458f-aa7c-8a8c1d83406a", "6dbfbd4b-cbdb-412c-8450-5aad6b6bbd08", "Visitor", "VISITOR" },
                    { "f9ccc546-3e40-49e9-92f8-d6f9e540a6fe", "09b2b3dd-5d48-4bb2-aad9-18544302e06e", "Teacher", "TEACHER" },
                    { "aba63205-098c-4594-8aeb-ee8b70371512", "48ec0915-f01c-4f47-99e6-6135e4fc1e06", "Student", "STUDENT" },
                    { "df4b2546-6818-4e22-87e6-671ded14f610", "07aa9511-25d1-4f76-b29e-f76cf7b1c86f", "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
