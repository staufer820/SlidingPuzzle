using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SlidingPuzzle.Server.Data.Migrations
{
    public partial class UpdatedDbScheme3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "TimePassed",
                table: "PlayerGames",
                type: "real",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "TimePassed",
                table: "PlayerGames",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);
        }
    }
}
