using Microsoft.EntityFrameworkCore;
using PostsWebApi.Models;

namespace PostWebApi.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
    }
}
