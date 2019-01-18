using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EfSamurai.Data.Migrations
{
    public partial class MyTenthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SecretIdentityId",
                table: "Samurais",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "SecretIdentity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecretIdentity", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Samurais_SecretIdentityId",
                table: "Samurais",
                column: "SecretIdentityId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Samurais_SecretIdentity_SecretIdentityId",
                table: "Samurais",
                column: "SecretIdentityId",
                principalTable: "SecretIdentity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Samurais_SecretIdentity_SecretIdentityId",
                table: "Samurais");

            migrationBuilder.DropTable(
                name: "SecretIdentity");

            migrationBuilder.DropIndex(
                name: "IX_Samurais_SecretIdentityId",
                table: "Samurais");

            migrationBuilder.DropColumn(
                name: "SecretIdentityId",
                table: "Samurais");
        }
    }
}
