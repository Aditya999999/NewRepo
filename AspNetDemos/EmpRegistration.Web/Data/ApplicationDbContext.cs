using EmpRegistration.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace EmpRegistration.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { 
        }

        public DbSet<EmpRegistration.Web.Models.ProductCategory> ProductCategory { get; set; }

        public DbSet<EmpRegistration.Web.Models.EmployeeRegistration> EmployeeRegistration { get; set; }
        
    }
}
