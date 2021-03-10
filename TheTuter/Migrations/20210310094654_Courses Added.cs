using Microsoft.EntityFrameworkCore.Migrations;

namespace TheTuter.Migrations
{
    public partial class CoursesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "d50e17a1-4cbf-4118-9dd0-b7347e636677", "6ecf90c6-d910-491d-8d5f-a79dc0311388", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d12504e6-e52a-4e6b-9306-08f1bb7e7c93", "fef6f84b-d706-4f1c-91ce-87aabb63ef76", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d12504e6-e52a-4e6b-9306-08f1bb7e7c93");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d50e17a1-4cbf-4118-9dd0-b7347e636677");

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "565b71a9-dbad-47e9-8a77-af128de1ddfc", "de51989b-932a-4fff-b95f-4b7370cb2492", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9cd04ae4-e76b-4389-90ac-05a3d3bb0643", "8db1cf0e-78ed-4c42-96f2-3d80922902a3", "Administrator", "ADMINISTRATOR" });
        }
    }
}
