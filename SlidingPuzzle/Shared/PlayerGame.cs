using System.ComponentModel.DataAnnotations;

namespace SlidingPuzzle.Shared;

[Serializable]
public class PlayerGame
{
    [Key]
    public int Id { get; set; }

    public byte[]? Image { get; set; }

    public float? TimePassed { get; set; }

    [Required]
    public List<PuzzlePiece> PuzzlePieces { get; set; }
}