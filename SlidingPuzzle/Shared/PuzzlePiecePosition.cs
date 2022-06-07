using System.ComponentModel.DataAnnotations;

namespace SlidingPuzzle.Shared;

[Serializable]
public class PuzzlePiecePosition
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int X { get; set; }

    [Required]
    public int Y { get; set; }

    [Required]
    public int PuzzlePieceId { get; set; }

    [Required]
    public virtual PuzzlePiece PuzzlePiece { get; set; }

    [Required]
    public int PlayerGameId { get; set; }

    [Required]
    public virtual PlayerGame PlayerGame { get; set; }
}