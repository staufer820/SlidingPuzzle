using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SlidingPuzzle.Server.Data.Migrations
{
    public partial class UpdatedDbScheme5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerGames_AspNetUsers_PlayerId",
                table: "PlayerGames");

            migrationBuilder.DropIndex(
                name: "IX_PlayerGames_PlayerId",
                table: "PlayerGames");

            migrationBuilder.DropColumn(
                name: "PlayerId",
                table: "PlayerGames");

            migrationBuilder.AddColumn<int>(
                name: "PlayerGameId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PlayerGameId",
                table: "AspNetUsers",
                column: "PlayerGameId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_PlayerGames_PlayerGameId",
                table: "AspNetUsers",
                column: "PlayerGameId",
                principalTable: "PlayerGames",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_PlayerGames_PlayerGameId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_PlayerGameId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PlayerGameId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "PlayerId",
                table: "PlayerGames",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerGames_PlayerId",
                table: "PlayerGames",
                column: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerGames_AspNetUsers_PlayerId",
                table: "PlayerGames",
                column: "PlayerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
