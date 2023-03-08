using EmployeeManagement.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeManagement.Models.TypeConfigurations
{
    public class EmployeeTypeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(b => b.EmployeeID);

            builder.Property(b => b.FirstName).IsRequired();
            builder.Property(b => b.MiddleName);
            builder.Property(b => b.LastName).IsRequired();
            builder.Property(b => b.PhoneNumber).IsRequired();
            builder.Property(b => b.Email).IsRequired();
            builder.Property(b => b.StreetAddress).IsRequired();
            builder.Property(b => b.City).IsRequired();
            builder.Property(b => b.State).IsRequired();
            builder.Property(b => b.PostalCode).IsRequired();
            builder.Property(b => b.SocialSecurityNumber).IsRequired();
            builder.Property(b => b.BirthDate).IsRequired();
            builder.Property(b => b.MaritalStatus).IsRequired();
            builder.Property(b => b.Gender).IsRequired();

            builder
                .HasMany(b => b.EmployeePositions)
                .WithOne(b => b.Employee)
                .HasForeignKey(b => b.EmployeeID)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(b => b.EmployeeEmergencyContacts)
                .WithOne(b => b.Employee)
                .HasForeignKey(b => b.EmployeeID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
