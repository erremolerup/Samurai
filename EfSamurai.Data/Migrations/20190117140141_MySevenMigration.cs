using Microsoft.EntityFrameworkCore.Migrations;

namespace EfSamurai.Data.Migrations
{
    public partial class MySevenMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quote",
                table: "Quotes");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Quotes",
                newName: "TypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "Quotes",
                newName: "Type");

            migrationBuilder.AddColumn<string>(
                name: "Quote",
                table: "Quotes",
                nullable: true);
        }
    }
}
