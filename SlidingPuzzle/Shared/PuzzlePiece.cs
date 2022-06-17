using System.ComponentModel.DataAnnotations;

namespace SlidingPuzzle.Shared;

[Serializable]
public class PuzzlePiece
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int StartX { get; set; }

    [Required]
    public int StartY { get; set; }

    [Required]
    public int X { get; set; }

    [Required]
    public int Y { get; set; }
    
}