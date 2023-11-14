using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gluschKt_42_20.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    group_id = table.Column<int>(type: "int", nullable: false, comment: "Идентификатор записи студента")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    group_name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, comment: "Номер группы")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_Group_group_id", x => x.group_id);
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    Subject_id = table.Column<int>(type: "int", nullable: false, comment: "Идентификатор предмета")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subject_name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, comment: "Предмет")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_Subject_Subject_id", x => x.Subject_id);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    student_id = table.Column<int>(type: "int", nullable: false, comment: "Идентификатор записи студента")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    first_name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, comment: "Имя студента"),
                    last_name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, comment: "Фамилия"),
                    middle_name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, comment: "Отчество"),
                    group_id = table.Column<int>(type: "int", nullable: false, comment: "Идентификатор группы")
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_Student_student_id", x => x.student_id);
                    table.ForeignKey(
                        name: "fk_f_group_id",
                        column: x => x.group_id,
                        principalTable: "Group",
                        principalColumn: "group_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "idx_Student_fk_f_group_id",
                table: "Student",
                column: "group_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Subject");

            migrationBuilder.DropTable(
                name: "Group");
        }
    }
}
