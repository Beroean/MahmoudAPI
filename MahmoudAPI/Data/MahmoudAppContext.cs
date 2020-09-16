using Microsoft.EntityFrameworkCore;
using MahmoudAPI.Models;

namespace MahmoudAPI.Data
{
    public class MahmoudAppContext : DbContext
    {
        public MahmoudAppContext(DbContextOptions<MahmoudAppContext> options)
            : base (options)
        {

        }

        public DbSet<Survey> Survey { get; set; }
    }
}
