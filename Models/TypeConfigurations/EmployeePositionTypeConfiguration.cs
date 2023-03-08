using EmployeeManagement.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Models.TypeConfigurations
{
    public class EmployeePositionTypeConfiguration : IEntityTypeConfiguration<EmployeePosition>
    {
        public void Configure(EntityTypeBuilder<EmployeePosition> builder)
        {
            builder.HasKey(b => new { b.EmployeePositionID, b.EmployeeID, b.PositionID });

            builder.Property(b => b.Status).IsRequired();
            builder.Property(b => b.EffectiveDate).IsRequired();

            builder
                .HasOne(b => b.Employee)
                .WithMany(b => b.EmployeePositions)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(b => b.Position)
                .WithMany(b => b.EmployeePositions)
                .OnDelete(DeleteBehavior.Restrict);
            
            builder
                .HasMany(b => b.EmployeePositionRates)
                .WithOne(b => b.EmployeePosition)
                .HasPrincipalKey(b => b.EmployeePositionID)
                .HasForeignKey(b => b.EmployeePositionID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
