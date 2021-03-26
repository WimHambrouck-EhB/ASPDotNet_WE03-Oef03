using Microsoft.EntityFrameworkCore.Migrations;

namespace Werkcollege03.Oef03.Migrations
{
    public partial class VaknaamUniek : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Naam",
                table: "Vakken",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vakken_Naam",
                table: "Vakken",
                column: "Naam",
                unique: true,
                filter: "[Naam] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Vakken_Naam",
                table: "Vakken");

            migrationBuilder.AlterColumn<string>(
                name: "Naam",
                table: "Vakken",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
