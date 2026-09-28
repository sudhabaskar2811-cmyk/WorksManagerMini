using Microsoft.EntityFrameworkCore;
using WorksManagerMini.Models;

namespace WorksManagerMini.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Job> Jobs { get; set; }
    }
}