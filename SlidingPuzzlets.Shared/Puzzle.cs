using System.ComponentModel.DataAnnotations;

namespace SlidingPuzzlets.Shared;

[Serializable]
public class Puzzle
{
    [Key]
    public int Id { get; set; }

    [Required]
    public virtual List<PuzzlePiece> PuzzlePieces { get; set; }

}