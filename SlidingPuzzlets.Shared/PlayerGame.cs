using System.ComponentModel.DataAnnotations;

namespace SlidingPuzzlets.Shared;

[Serializable]
public class PlayerGame
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int PlayerId { get; set; }

    [Required]
    public int PuzzleId { get; set; }
    
    public float TimePassed { get; set; }

    [Required]
    public List<PuzzlePiecePosition> PuzzlePiecePositions { get; set; }
}