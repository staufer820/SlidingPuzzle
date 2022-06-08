using Microsoft.EntityFrameworkCore;
using SlidingPuzzlets.Shared;

namespace SlidingPuzzlets.Core;


public class SlidingPuzzleContext : DbContext
{
    public SlidingPuzzleContext(DbContextOptions<SlidingPuzzleContext> options) : base(options) { }
    public DbSet<Player> Players { get; set; }
    public DbSet<PlayerGame> PlayerGames { get; set; }
    public DbSet<Puzzle> Puzzles { get; set; }
    public DbSet<PuzzlePiece> PuzzlePieces { get; set; }
    public DbSet<PuzzlePiecePosition> PuzzlePiecePositions { get; set; }
}