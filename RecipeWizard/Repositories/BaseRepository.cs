using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace RecipeWizard.Repositories
{
    public class BaseRepository : DbContext
    {
        public readonly string ConnectionString;

        public BaseRepository(IConfiguration configuration)
        {
            ConnectionString = configuration.GetValue<string>("connectionString");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
