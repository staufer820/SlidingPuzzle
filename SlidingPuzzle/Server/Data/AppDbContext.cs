﻿using Microsoft.EntityFrameworkCore;
using SlidingPuzzle.Shared;

namespace SlidingPuzzle.Server.Data;


public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Player> Players { get; set; }
    public DbSet<PlayerGame> PlayerGames { get; set; }
    public DbSet<Puzzle> Puzzles { get; set; }
    public DbSet<PuzzlePiece> PuzzlePieces { get; set; }
    public DbSet<PuzzlePiecePosition> PuzzlePiecePositions { get; set; }
}