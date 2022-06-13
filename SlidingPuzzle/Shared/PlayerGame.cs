using System.ComponentModel.DataAnnotations;

namespace SlidingPuzzle.Shared

[Serializable]
public class PlayerGame
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public virtual Player Player { get; set; }

    [Required]
    public int PuzzleId { get; set; }

    [Required]
    public virtual Puzzle Puzzle { get; set; }

    public float TimePassed { get; set; }

    [Required]
    public List<PuzzlePiecePosition> PuzzlePiecePositions { get; set; }
}