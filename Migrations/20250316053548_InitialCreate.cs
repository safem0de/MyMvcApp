using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyMvcApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CourseName = table.Column<string>(type: "TEXT", nullable: false),
                    Credit = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GroupCode = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Studyings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CourseId = table.Column<int>(type: "INTEGER", nullable: false),
                    StudentId = table.Column<int>(type: "INTEGER", nullable: false),
                    Term = table.Column<int>(type: "INTEGER", nullable: false),
                    Year = table.Column<int>(type: "INTEGER", nullable: false),
                    Score = table.Column<int>(type: "INTEGER", nullable: false),
                    StudentGroupId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studyings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Studyings_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Studyings_StudentGroups_StudentGroupId",
                        column: x => x.StudentGroupId,
                        principalTable: "StudentGroups",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseName", "Credit" },
                values: new object[,]
                {
                    { 1, "ภาษาไทยเพื่ออาชีพ", 3 },
                    { 2, "ภาษาอังกฤษฟัง-พูด 1", 3 },
                    { 3, "หน้าที่พลเมืองและศีลธรรม", 3 }
                });

            migrationBuilder.InsertData(
                table: "StudentGroups",
                columns: new[] { "Id", "GroupCode" },
                values: new object[,]
                {
                    { 1, "2/1" },
                    { 2, "2/2" },
                    { 3, "2/3" }
                });

            migrationBuilder.InsertData(
                table: "Studyings",
                columns: new[] { "Id", "CourseId", "Score", "StudentGroupId", "StudentId", "Term", "Year" },
                values: new object[,]
                {
                    { 1, 1, 3, null, 1, 1, 2017 },
                    { 2, 1, 3, null, 2, 2, 2016 },
                    { 3, 1, 4, null, 3, 2, 2017 },
                    { 4, 2, 2, null, 4, 2, 2016 },
                    { 5, 2, 4, null, 5, 1, 2017 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Studyings_CourseId",
                table: "Studyings",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Studyings_StudentGroupId",
                table: "Studyings",
                column: "StudentGroupId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Studyings");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "StudentGroups");
        }
    }
}
