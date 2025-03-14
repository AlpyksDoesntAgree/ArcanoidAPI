using Microsoft.EntityFrameworkCore;
using TestApi3K.Model;

namespace TestApi3K.DataBaseContext
{
    public class ContextDb : DbContext
    {
        public ContextDb(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Skins> Skins { get; set; }
        public DbSet<Skins_Users> Skins_Users { get; set; }
    }
}
