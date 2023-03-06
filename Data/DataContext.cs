using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=ITD-VU132KA\\SQLEXPRESS;Database=EmployeeManagementDB;Trusted_Connection=true;TrustServerCertificate=true;");
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
