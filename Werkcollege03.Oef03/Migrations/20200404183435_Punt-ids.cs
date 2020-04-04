using Microsoft.EntityFrameworkCore.Migrations;

namespace Werkcollege03.Oef03.Migrations
{
    public partial class Puntids : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Punten_Studenten_StudentID",
                table: "Punten");

            migrationBuilder.DropForeignKey(
                name: "FK_Punten_Vakken_VakID",
                table: "Punten");

            migrationBuilder.AlterColumn<int>(
                name: "VakID",
                table: "Punten",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StudentID",
                table: "Punten",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

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

            migrationBuilder.AlterColumn<int>(
                name: "VakID",
                table: "Punten",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "StudentID",
                table: "Punten",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Punten_Studenten_StudentID",
                table: "Punten",
                column: "StudentID",
                principalTable: "Studenten",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Punten_Vakken_VakID",
                table: "Punten",
                column: "VakID",
                principalTable: "Vakken",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
