using Microsoft.EntityFrameworkCore;
using TestForLsiSoftware.Models;

namespace TestForLsiSoftware.EF
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opts) : base(opts) { }

        public DbSet<Raport> Raports { get; set; }
    }
}
