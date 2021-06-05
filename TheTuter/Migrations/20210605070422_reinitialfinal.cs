using Microsoft.EntityFrameworkCore.Migrations;

namespace TheTuter.Migrations
{
    public partial class reinitialfinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b4e28fb-0b64-43f3-b330-d4c7a49d8c71");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71097fb9-892d-49c6-9ec8-50260a9ea56c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9c80e49f-d71b-4a3e-97a8-4ad0620f4031");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a41353a5-96fe-4ddb-b27f-88e61c11384c");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "a41353a5-96fe-4ddb-b27f-88e61c11384c", "cc630c16-d55e-4427-b767-0a0c0aaf3348", "Visitor", "VISITOR" },
                    { "9c80e49f-d71b-4a3e-97a8-4ad0620f4031", "bb680bd3-46d0-4465-b9a4-4632c0423686", "Teacher", "TEACHER" },
                    { "4b4e28fb-0b64-43f3-b330-d4c7a49d8c71", "04e3ec53-2804-4d54-9a9a-feb44a71c660", "Student", "STUDENT" },
                    { "71097fb9-892d-49c6-9ec8-50260a9ea56c", "0220d759-80c5-4cc3-8612-27ad784943b2", "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
