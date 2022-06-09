using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SlidingPuzzle.Server.Data.Migrations
{
    public partial class UpdatedDbScheme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerGames_AspNetUsers_PlayerId",
                table: "PlayerGames");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerGames_Puzzles_PuzzleId",
                table: "PlayerGames");

            migrationBuilder.DropForeignKey(
                name: "FK_PuzzlePieces_Puzzles_PuzzleId",
                table: "PuzzlePieces");

            migrationBuilder.DropTable(
                name: "PuzzlePiecePositions");

            migrationBuilder.DropTable(
                name: "Puzzles");

            migrationBuilder.DropIndex(
                name: "IX_PuzzlePieces_PuzzleId",
                table: "PuzzlePieces");

            migrationBuilder.DropIndex(
                name: "IX_PlayerGames_PlayerId",
                table: "PlayerGames");

            migrationBuilder.DropIndex(
                name: "IX_PlayerGames_PuzzleId",
                table: "PlayerGames");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "PuzzlePieces");

            migrationBuilder.DropColumn(
                name: "PuzzleId",
                table: "PlayerGames");

            migrationBuilder.RenameColumn(
                name: "PuzzleId",
                table: "PuzzlePieces",
                newName: "StartY");

            migrationBuilder.AddColumn<int>(
                name: "PlayerGameId",
                table: "PuzzlePieces",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StartX",
                table: "PuzzlePieces",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "PlayerId",
                table: "PlayerGames",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "PlayerGames",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PlayerId1",
                table: "PlayerGames",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_PuzzlePieces_PlayerGameId",
                table: "PuzzlePieces",
                column: "PlayerGameId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerGames_PlayerId1",
                table: "PlayerGames",
                column: "PlayerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerGames_AspNetUsers_PlayerId1",
                table: "PlayerGames",
                column: "PlayerId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PuzzlePieces_PlayerGames_PlayerGameId",
                table: "PuzzlePieces",
                column: "PlayerGameId",
                principalTable: "PlayerGames",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerGames_AspNetUsers_PlayerId1",
                table: "PlayerGames");

            migrationBuilder.DropForeignKey(
                name: "FK_PuzzlePieces_PlayerGames_PlayerGameId",
                table: "PuzzlePieces");

            migrationBuilder.DropIndex(
                name: "IX_PuzzlePieces_PlayerGameId",
                table: "PuzzlePieces");

            migrationBuilder.DropIndex(
                name: "IX_PlayerGames_PlayerId1",
                table: "PlayerGames");

            migrationBuilder.DropColumn(
                name: "PlayerGameId",
                table: "PuzzlePieces");

            migrationBuilder.DropColumn(
                name: "StartX",
                table: "PuzzlePieces");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "PlayerGames");

            migrationBuilder.DropColumn(
                name: "PlayerId1",
                table: "PlayerGames");

            migrationBuilder.RenameColumn(
                name: "StartY",
                table: "PuzzlePieces",
                newName: "PuzzleId");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "PuzzlePieces",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PlayerId",
                table: "PlayerGames",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "PuzzleId",
                table: "PlayerGames",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PuzzlePiecePositions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerGameId = table.Column<int>(type: "int", nullable: false),
                    PuzzlePieceId = table.Column<int>(type: "int", nullable: false),
                    X = table.Column<int>(type: "int", nullable: false),
                    Y = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PuzzlePiecePositions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PuzzlePiecePositions_PlayerGames_PlayerGameId",
                        column: x => x.PlayerGameId,
                        principalTable: "PlayerGames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PuzzlePiecePositions_PuzzlePieces_PuzzlePieceId",
                        column: x => x.PuzzlePieceId,
                        principalTable: "PuzzlePieces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Puzzles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Puzzles", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PuzzlePieces_PuzzleId",
                table: "PuzzlePieces",
                column: "PuzzleId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerGames_PlayerId",
                table: "PlayerGames",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerGames_PuzzleId",
                table: "PlayerGames",
                column: "PuzzleId");

            migrationBuilder.CreateIndex(
                name: "IX_PuzzlePiecePositions_PlayerGameId",
                table: "PuzzlePiecePositions",
                column: "PlayerGameId");

            migrationBuilder.CreateIndex(
                name: "IX_PuzzlePiecePositions_PuzzlePieceId",
                table: "PuzzlePiecePositions",
                column: "PuzzlePieceId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerGames_AspNetUsers_PlayerId",
                table: "PlayerGames",
                column: "PlayerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerGames_Puzzles_PuzzleId",
                table: "PlayerGames",
                column: "PuzzleId",
                principalTable: "Puzzles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PuzzlePieces_Puzzles_PuzzleId",
                table: "PuzzlePieces",
                column: "PuzzleId",
                principalTable: "Puzzles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
