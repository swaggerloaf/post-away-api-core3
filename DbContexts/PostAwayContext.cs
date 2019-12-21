using PostAway.API.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace PostAway.API.DbContexts
{
  public class PostAwayContext : DbContext
  {
    public PostAwayContext(DbContextOptions<PostAwayContext> options)
       : base(options)
    {
    }

    public DbSet<Post> Posts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
    }
  }
}
