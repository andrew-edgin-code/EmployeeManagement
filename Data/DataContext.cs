using EmployeeManagement.Models.Entities;
using EmployeeManagement.Models.TypeConfigurations;
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
        public DbSet<EmployeeEmergencyContact> EmployeeEmergencyContacts { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<EmployeePosition> EmployeePositions { get; set; }
        public DbSet<EmployeePositionRate> EmployeePositionRates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeTypeConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeEmergencyContactTypeConfiguration());
            modelBuilder.ApplyConfiguration(new PositionTypeConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeePositionTypeConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeePositionRateTypeConfiguration());
        }
    }
}
