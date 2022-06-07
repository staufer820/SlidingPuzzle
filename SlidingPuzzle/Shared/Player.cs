using System.ComponentModel.DataAnnotations;

namespace SlidingPuzzle.Shared;

[Serializable]
public class Player
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Email { get; set; }

    [Required]
    public string UserName { get; set; }

    [Required]
    public string PwHash { get; set; }
}