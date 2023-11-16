using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gluschKt_42_20.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Grade",
                columns: table => new
                {
                    grade_id = table.Column<int>(type: "int", nullable: false, comment: "Идентификатор записи студента")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    student_id = table.Column<int>(type: "int", nullable: false, comment: "Идентификатор"),
                    subject_id = table.Column<int>(type: "int", nullable: false, comment: "Идентификатор группы"),
                    student_grade = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, comment: "Номер группы")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_Grade_grade_id", x => x.grade_id);
                    table.ForeignKey(
                        name: "fk_f_student_id",
                        column: x => x.student_id,
                        principalTable: "Student",
                        principalColumn: "student_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_f_subject_id",
                        column: x => x.subject_id,
                        principalTable: "Subject",
                        principalColumn: "Subject_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "idx_Grade_fk_f_student_id",
                table: "Grade",
                column: "student_id");

            migrationBuilder.CreateIndex(
                name: "idx_Grade_fk_f_subject_id",
                table: "Grade",
                column: "subject_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Grade");
        }
    }
}
