using EmployeeManagement.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Models.TypeConfigurations
{
    public class EmployeePostionRateTypeConfiguration : IEntityTypeConfiguration<EmployeePositionRate>
    {
        public void Configure(EntityTypeBuilder<EmployeePositionRate> builder)
        {
            builder.HasKey(b => new { b.EmployeePositionRateID, b.EmployeePositionID });

            builder.Property(b => b.Rate).IsRequired();

            builder
                .HasOne(b => b.EmployeePosition)
                .WithMany(b => b.EmployeePositionRates)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
