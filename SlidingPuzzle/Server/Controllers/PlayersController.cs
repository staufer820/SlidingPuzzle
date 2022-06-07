using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SlidingPuzzle.Server.Data;
using SlidingPuzzle.Shared;

namespace SlidingPuzzle.Server.Controllers;


[ApiController]
[Route("api/players")]
public class PlayersController : ControllerBase
{
    private readonly AppDbContext dbContext;

    public PlayersController(AppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    [HttpPost]
    public async Task<Player> Add([FromBody] Player player)
    {
        EntityEntry<Player> playerEntry = await this.dbContext.Players.AddAsync(player);
        await this.dbContext.SaveChangesAsync();
        return playerEntry.Entity;
    }

    [HttpGet("{userName}")]
    public async Task<Player> Get(string userName)
    {
        return await this.dbContext.Players.FirstAsync(p => p.UserName == userName);
    }

    [HttpGet]
    public async  Task<List<Player>> Get()
    {
        return new List<Player> { new Player() { Email = "test", UserName = "tester", PwHash = "222" } };
        return await this.dbContext.Players.ToListAsync();
    }
}