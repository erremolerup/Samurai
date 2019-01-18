using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EfSamurai.Data.Migrations
{
    public partial class MyThirteenthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BattleLogId",
                table: "Battle",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BattleLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BattleLog", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Battle_BattleLogId",
                table: "Battle",
                column: "BattleLogId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Battle_BattleLog_BattleLogId",
                table: "Battle",
                column: "BattleLogId",
                principalTable: "BattleLog",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Battle_BattleLog_BattleLogId",
                table: "Battle");

            migrationBuilder.DropTable(
                name: "BattleLog");

            migrationBuilder.DropIndex(
                name: "IX_Battle_BattleLogId",
                table: "Battle");

            migrationBuilder.DropColumn(
                name: "BattleLogId",
                table: "Battle");
        }
    }
}
