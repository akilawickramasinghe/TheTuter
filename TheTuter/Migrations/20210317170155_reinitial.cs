using Microsoft.EntityFrameworkCore.Migrations;

namespace TheTuter.Migrations
{
    public partial class reinitial : Migration
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

            migrationBuilder.AddColumn<bool>(
                name: "IsStudent",
                table: "Users",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    CourseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId1 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.CourseId);
                    table.ForeignKey(
                        name: "FK_Teacher_Course_CourseId1",
                        column: x => x.CourseId1,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "57d44a68-c549-4990-9c0a-eec56cb894ca", "a15461a2-2069-4822-a537-c3a652ce882c", "Visitor", "VISITOR" },
                    { "efd8a166-5b8f-46db-b7ec-a351c38de84d", "9354568b-7f90-4530-a492-900107d43d3b", "Teacher", "TEACHER" },
                    { "d19bce42-c3d2-4263-a55a-862393ba8331", "75ca6e53-c049-43ef-8c95-ac0cc38cae8d", "Student", "STUDENT" },
                    { "0228e346-4e1b-4217-b644-e22ef93e3034", "04dfaabc-ef02-4168-9347-4743689034f2", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_CourseId1",
                table: "Teacher",
                column: "CourseId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teacher");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "0228e346-4e1b-4217-b644-e22ef93e3034");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "57d44a68-c549-4990-9c0a-eec56cb894ca");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "d19bce42-c3d2-4263-a55a-862393ba8331");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "efd8a166-5b8f-46db-b7ec-a351c38de84d");

            migrationBuilder.DropColumn(
                name: "IsStudent",
                table: "Users");

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
