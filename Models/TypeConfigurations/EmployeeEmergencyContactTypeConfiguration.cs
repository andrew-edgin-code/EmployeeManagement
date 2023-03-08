using EmployeeManagement.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeManagement.Models.TypeConfigurations
{
    public class EmployeeEmergencyContactTypeConfiguration : IEntityTypeConfiguration<EmployeeEmergencyContact>
    {
        public void Configure(EntityTypeBuilder<EmployeeEmergencyContact> builder)
        {
            builder.HasKey(b => new { b.EmployeeEmergencyContactID, b.EmployeeID });

            builder.Property(b => b.Name).IsRequired();
            builder.Property(b => b.Relationship);
            builder.Property(b => b.PhoneNumber).IsRequired();
            builder.Property(b => b.StreetAddress);
            builder.Property(b => b.City);
            builder.Property(b => b.State);

            builder
                .HasOne(b => b.Employee)
                .WithMany(b => b.EmployeeEmergencyContacts)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
