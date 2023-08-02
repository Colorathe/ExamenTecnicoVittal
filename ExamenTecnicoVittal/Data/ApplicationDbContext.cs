using ExamenTecnicoVittal.Models;
using Microsoft.EntityFrameworkCore;

namespace ExamenTecnicoVittal.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<User> Users { get; set; }
    }
}