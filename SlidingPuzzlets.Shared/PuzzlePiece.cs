using System.ComponentModel.DataAnnotations;

namespace SlidingPuzzlets.Shared;

[Serializable]
public class PuzzlePiece
{
    [Key]
    public int Id { get; set; }


    public byte[]? Image { get; set; }

    [Required]
    public int X { get; set; }

    [Required]
    public int Y { get; set; }

    [Required]
    public int PuzzleId { get; set; }
    
    [Required]
    public virtual Puzzle Puzzle { get; set; }

    [Required]
    public List<PuzzlePiecePosition> PuzzlePiecePositions { get; set; }
}