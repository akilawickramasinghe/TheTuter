using Microsoft.EntityFrameworkCore.Migrations;

namespace TheTuter.Migrations
{
    public partial class JWTCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "3593295d-f34c-478a-92a5-44ff8f955457");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "8d4d4b1d-806c-4b2b-b13f-f4b24e843f9a");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "565b71a9-dbad-47e9-8a77-af128de1ddfc", "de51989b-932a-4fff-b95f-4b7370cb2492", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9cd04ae4-e76b-4389-90ac-05a3d3bb0643", "8db1cf0e-78ed-4c42-96f2-3d80922902a3", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "565b71a9-dbad-47e9-8a77-af128de1ddfc");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "9cd04ae4-e76b-4389-90ac-05a3d3bb0643");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3593295d-f34c-478a-92a5-44ff8f955457", "5dd9280d-94b3-417b-9d27-2e3352ac079c", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8d4d4b1d-806c-4b2b-b13f-f4b24e843f9a", "077ee269-79dd-44de-8bce-ba7e55ea5746", "Administrator", "ADMINISTRATOR" });
        }
    }
}
