using Microsoft.EntityFrameworkCore;

namespace BG_Dancers_and_Schools.Data
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext>options):base(options)
        {

        }
        public DbSet<Protocol> Protocol { get; set; }
    }
}
