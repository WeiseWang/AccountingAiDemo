using Microsoft.EntityFrameworkCore;

public class MemoryDbContext : DbContext
{
    public MemoryDbContext(DbContextOptions<MemoryDbContext> options)
        : base(options)
    {
    }

    public DbSet<Record> Records { get; set; }
}