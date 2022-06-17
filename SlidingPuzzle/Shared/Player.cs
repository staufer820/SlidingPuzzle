using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace SlidingPuzzle.Shared
{
    public class Player : IdentityUser
    {
        public PlayerGame? PlayerGame { get; set; }
    }
}