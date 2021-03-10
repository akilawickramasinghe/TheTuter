using Microsoft.EntityFrameworkCore.Migrations;

namespace TheTuter.Migrations
{
    public partial class Modelsadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "015ce3d4-bd7f-43c3-83e2-47653cd23551");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "311643df-7a17-471c-8ad2-51bbd86c3ded");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "015ce3d4-bd7f-43c3-83e2-47653cd23551", "6c2ee439-464c-4f0c-801b-fbdd0fc64fcf", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "311643df-7a17-471c-8ad2-51bbd86c3ded", "36360c8e-ac8a-466e-879e-5d87c45a1a4c", "Administrator", "ADMINISTRATOR" });
        }
    }
}
