using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SlidingPuzzle.Server.Data;
using SlidingPuzzle.Shared;

namespace SlidingPuzzle.Server.Controllers;


[ApiController]
[Route("api/[controller]")]
public class PlayersController : ControllerBase
{
    private readonly AppDbContext dbContext;

    public PlayersController(AppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }


    [HttpPut("{id}")]
    public async Task<Player> Put(Guid id, [FromBody] Player player)
    {
        var edit = await this.dbContext.Players.FindAsync(id);
        if (edit != null)
        {
            edit.Email = player.Email;
            edit.UserName = player.UserName;
            edit.PwHash = player.PwHash;
            await this.dbContext.SaveChangesAsync();
        }
        return edit;
    }

    [HttpPost]
    public async Task<Player> Add([FromBody] Player player)
    {
        EntityEntry<Player> playerEntry = await this.dbContext.Players.AddAsync(player);
        await this.dbContext.SaveChangesAsync();
        return playerEntry.Entity;
    }

    [HttpGet]
    public async Task<IEnumerable<Player>> Get()
    {
        return await Task.Factory.StartNew<IEnumerable<Player>>(() =>
        {
                return this.dbContext.Players;
        });
    }

    [HttpGet("{Id}")]
    public async Task<Player> Get(int Id)
    {
        return await this.dbContext.Players.FirstAsync(p => p.Id == Id);
    }

}