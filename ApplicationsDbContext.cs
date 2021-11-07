using Microsoft.EntityFrameworkCore;
using TodoCore.Models;

namespace TodoCore
{
    public class ApplicationsDbContext : DbContext
    {
        public ApplicationsDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Todo> Todos { get; set; }
    }
}