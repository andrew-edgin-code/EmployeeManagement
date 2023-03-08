using EmployeeManagement.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeManagement.Models.TypeConfigurations
{
    public class PositionTypeConfiguration : IEntityTypeConfiguration<Position>
    {
        public void Configure(EntityTypeBuilder<Position> builder)
        {
            builder.HasKey(b => b.PositionID);

            builder.Property(b => b.Title).IsRequired();
            builder.Property(b => b.Code).IsRequired();

            builder
                .HasMany(b => b.EmployeePositions)
                .WithOne(b => b.Position)
                .HasForeignKey(b => b.PositionID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
