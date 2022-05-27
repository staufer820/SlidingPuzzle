using System.Data.Entity;

namespace SlidingPuzzlets.Core;

public class Player
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string UserName { get; set; }
    public string PwHash { get; set; }
}
public class PlayerGame
{
    public int Id { get; set; }
    public int PlayerId { get; set; }
    public int PuzzleId { get; set; }
    public float TimePassed { get; set; }
    public List<PuzzlePiecePosition> PuzzlePiecePositions { get; set; }
}

public class Puzzle
{
    public int Id { get; set; }
    public virtual List<PuzzlePiece> PuzzlePieces { get; set; }

}
public class PuzzlePiece
{
    public int Id { get; set; }
    public byte[]? Image { get; set; }
    public int X { get; set; }
    public int Y { get; set; }

    public int PuzzleId { get; set; }
    public virtual Puzzle Puzzle { get; set; }
    public List<PuzzlePiecePosition> PuzzlePiecePositions { get; set; }
}

public class PuzzlePiecePosition
{
    public int Id { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    public int PuzzlePieceId { get; set; }
    public virtual PuzzlePiece PuzzlePiece { get; set; }
    public int PlayerGameId { get; set; }
    public virtual PlayerGame PlayerGame { get; set; }
}

public class SlidingPuzzleContext : DbContext
{
    public DbSet<Player> Players { get; set; }
    public DbSet<PlayerGame> PlayerGames { get; set; }
    public DbSet<Puzzle> Puzzles { get; set; }
    public DbSet<PuzzlePiece> PuzzlePieces { get; set; }
    public DbSet<PuzzlePiecePosition> PuzzlePiecePositions { get; set; }
}