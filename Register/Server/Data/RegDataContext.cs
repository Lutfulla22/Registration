using Microsoft.EntityFrameworkCore;
using Register.Shared;

namespace Register.Server.Data
{
    public class RegDataContext : DbContext
    {
        public RegDataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Users> User { get; set; }
    }
}
