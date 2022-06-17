using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SlidingPuzzle.Server.Data.Migrations
{
    public partial class UpdatedDbScheme4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PuzzlePieces_PlayerGames_PlayerGameId",
                table: "PuzzlePieces");

            migrationBuilder.AlterColumn<int>(
                name: "PlayerGameId",
                table: "PuzzlePieces",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_PuzzlePieces_PlayerGames_PlayerGameId",
                table: "PuzzlePieces",
                column: "PlayerGameId",
                principalTable: "PlayerGames",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PuzzlePieces_PlayerGames_PlayerGameId",
                table: "PuzzlePieces");

            migrationBuilder.AlterColumn<int>(
                name: "PlayerGameId",
                table: "PuzzlePieces",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PuzzlePieces_PlayerGames_PlayerGameId",
                table: "PuzzlePieces",
                column: "PlayerGameId",
                principalTable: "PlayerGames",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
