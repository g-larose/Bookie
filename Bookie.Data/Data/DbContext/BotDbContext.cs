using Microsoft.EntityFrameworkCore;
namespace Bookie.Data.Data
{
    public class BotDbContext : DbContext
    {
        public BotDbContext(DbContextOptions options) : base(options) { }

    }
}
