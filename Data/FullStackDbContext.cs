using Microsoft.EntityFrameworkCore;
using FullStackNET.Models;

namespace FullStackNET.Data
{
    public class FullStackDbContext : DbContext
    {
        public FullStackDbContext(DbContextOptions options) : base(options) { 
            
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
