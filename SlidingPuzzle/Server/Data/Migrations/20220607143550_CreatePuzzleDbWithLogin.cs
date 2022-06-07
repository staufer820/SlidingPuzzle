using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SlidingPuzzle.Server.Data.Migrations
{
    public partial class CreatePuzzleDbWithLogin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "PlayerGames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PuzzleId = table.Column<int>(type: "int", nullable: false),
                    TimePassed = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerGames", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerGames_AspNetUsers_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerGames_Puzzles_PuzzleId",
                        column: x => x.PuzzleId,
                        principalTable: "Puzzles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PuzzlePieces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    X = table.Column<int>(type: "int", nullable: false),
                    Y = table.Column<int>(type: "int", nullable: false),
                    PuzzleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PuzzlePieces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PuzzlePieces_Puzzles_PuzzleId",
                        column: x => x.PuzzleId,
                        principalTable: "Puzzles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PuzzlePiecePositions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    X = table.Column<int>(type: "int", nullable: false),
                    Y = table.Column<int>(type: "int", nullable: false),
                    PuzzlePieceId = table.Column<int>(type: "int", nullable: false),
                    PlayerGameId = table.Column<int>(type: "int", nullable: false)
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
                        onDelete: ReferentialAction.NoAction);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_PuzzlePieces_PuzzleId",
                table: "PuzzlePieces",
                column: "PuzzleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PuzzlePiecePositions");

            migrationBuilder.DropTable(
                name: "PlayerGames");

            migrationBuilder.DropTable(
                name: "PuzzlePieces");

            migrationBuilder.DropTable(
                name: "Puzzles");
        }
    }
}
