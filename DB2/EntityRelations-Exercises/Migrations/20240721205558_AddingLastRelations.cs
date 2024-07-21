using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P02_FootballBetting.Data.Migrations
{
    public partial class AddingLastRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_PlayerStatistic_PlayerId",
                table: "PlayerStatistic",
                column: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerStatistic_Games_GameId",
                table: "PlayerStatistic",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerStatistic_Players_PlayerId",
                table: "PlayerStatistic",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "PlayerId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerStatistic_Games_GameId",
                table: "PlayerStatistic");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerStatistic_Players_PlayerId",
                table: "PlayerStatistic");

            migrationBuilder.DropIndex(
                name: "IX_PlayerStatistic_PlayerId",
                table: "PlayerStatistic");
        }
    }
}
