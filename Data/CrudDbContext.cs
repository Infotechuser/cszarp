using WebApplication1.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
    public class CrudDbContext : DbContext
    {
        public CrudDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
