using LR4.Models;
using Microsoft.EntityFrameworkCore;

namespace LR4.DB;

public sealed class LR4Context:DbContext
{
    public DbSet<User> Users { get; set; }
    public LR4Context(DbContextOptions<LR4Context> options):base(options)
    {
        Database.EnsureCreated();
    }
}