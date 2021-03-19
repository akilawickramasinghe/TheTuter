using Microsoft.EntityFrameworkCore.Migrations;

namespace TheTuter.Migrations
{
    public partial class reinitial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teacher");

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

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tId",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Users",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    sId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.sId);
                });

            migrationBuilder.CreateTable(
                name: "CourseStudents",
                columns: table => new
                {
                    CourseId = table.Column<int>(nullable: false),
                    StudentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseStudents", x => new { x.CourseId, x.StudentId });
                    table.ForeignKey(
                        name: "FK_CourseStudents_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseStudents_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "sId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9bdc88a2-a35b-4b36-98e8-36362a0e9325", "499b44f5-976a-4fb4-937f-958f3ced59ff", "Visitor", "VISITOR" },
                    { "9e2ab56e-04e7-4c5b-a3a3-e690c0bc69e0", "af012e3f-7c5e-412b-919b-027f62436a59", "Teacher", "TEACHER" },
                    { "467c1e91-55d3-4e44-a9fd-5cbf16a4b6ca", "f7528fe8-2b1e-4cf2-a29a-f08d3d4a73b9", "Student", "STUDENT" },
                    { "872596ae-66a6-4dcb-84cf-41d7169cf099", "f5c8de18-a876-4b8d-8228-146fa5c35cf9", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_CourseId",
                table: "Users",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseStudents_StudentId",
                table: "CourseStudents",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Course_CourseId",
                table: "Users",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Course_CourseId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "CourseStudents");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Users_CourseId",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "467c1e91-55d3-4e44-a9fd-5cbf16a4b6ca");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "872596ae-66a6-4dcb-84cf-41d7169cf099");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "9bdc88a2-a35b-4b36-98e8-36362a0e9325");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "9e2ab56e-04e7-4c5b-a3a3-e690c0bc69e0");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "tId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Users");

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId1 = table.Column<int>(type: "int", nullable: false)
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
    }
}
