using BookingService.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookingService.Data;

public class CoreDataDbContext : DbContext
{
    public CoreDataDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<CoreData> CoreDatas { get; set; }
}
