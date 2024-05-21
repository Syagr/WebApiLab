using Microsoft.EntityFrameworkCore;

namespace WebApiLab.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<RpgCharacter> RpgCharacter { get; set; }
    }
}