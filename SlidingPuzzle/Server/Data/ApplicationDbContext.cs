using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SlidingPuzzle.Shared;

namespace SlidingPuzzle.Server.Data;

public class ApplicationDbContext : ApiAuthorizationDbContext<Player>
{
    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options,
        IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
    {

    }
    public DbSet<Player> Players { get; set; }
    public DbSet<PlayerGame> PlayerGames { get; set; }
    public DbSet<Puzzle> Puzzles { get; set; }
    public DbSet<PuzzlePiece> PuzzlePieces { get; set; }
    public DbSet<PuzzlePiecePosition> PuzzlePiecePositions { get; set; }

}