using Microsoft.EntityFrameworkCore;
using Teackinggg.Models;

namespace Teackinggg.Data
{
    public class IssueDbContext : DbContext
    {
        public IssueDbContext(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<Issue> Issues { get; set; }
    }
}
