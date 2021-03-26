using Microsoft.EntityFrameworkCore.Migrations;

namespace Werkcollege03.Oef03.Migrations
{
    public partial class ExtraDbSets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Punt_Student_StudentID",
                table: "Punt");

            migrationBuilder.DropForeignKey(
                name: "FK_Punt_Vak_VakID",
                table: "Punt");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vak",
                table: "Vak");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Punt",
                table: "Punt");

            migrationBuilder.RenameTable(
                name: "Vak",
                newName: "Vakken");

            migrationBuilder.RenameTable(
                name: "Student",
                newName: "Studenten");

            migrationBuilder.RenameTable(
                name: "Punt",
                newName: "Punten");

            migrationBuilder.RenameIndex(
                name: "IX_Punt_VakID",
                table: "Punten",
                newName: "IX_Punten_VakID");

            migrationBuilder.RenameIndex(
                name: "IX_Punt_StudentID",
                table: "Punten",
                newName: "IX_Punten_StudentID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vakken",
                table: "Vakken",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Studenten",
                table: "Studenten",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Punten",
                table: "Punten",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Punten_Studenten_StudentID",
                table: "Punten",
                column: "StudentID",
                principalTable: "Studenten",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Punten_Vakken_VakID",
                table: "Punten",
                column: "VakID",
                principalTable: "Vakken",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Punten_Studenten_StudentID",
                table: "Punten");

            migrationBuilder.DropForeignKey(
                name: "FK_Punten_Vakken_VakID",
                table: "Punten");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vakken",
                table: "Vakken");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Studenten",
                table: "Studenten");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Punten",
                table: "Punten");

            migrationBuilder.RenameTable(
                name: "Vakken",
                newName: "Vak");

            migrationBuilder.RenameTable(
                name: "Studenten",
                newName: "Student");

            migrationBuilder.RenameTable(
                name: "Punten",
                newName: "Punt");

            migrationBuilder.RenameIndex(
                name: "IX_Punten_VakID",
                table: "Punt",
                newName: "IX_Punt_VakID");

            migrationBuilder.RenameIndex(
                name: "IX_Punten_StudentID",
                table: "Punt",
                newName: "IX_Punt_StudentID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vak",
                table: "Vak",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Punt",
                table: "Punt",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Punt_Student_StudentID",
                table: "Punt",
                column: "StudentID",
                principalTable: "Student",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Punt_Vak_VakID",
                table: "Punt",
                column: "VakID",
                principalTable: "Vak",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
