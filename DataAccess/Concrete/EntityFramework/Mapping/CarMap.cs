using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EntityFramework.Mapping
{
    public class CarMap : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).UseIdentityColumn();

            builder.Property(i => i.ModelYear).IsRequired();
            builder.Property(i => i.DailyPrice).IsRequired();
            builder.Property(i => i.Description).IsRequired(false);

            builder.HasMany(i => i.Rentals).WithOne(i => i.Car).HasForeignKey(i => i.CarId).OnDelete(DeleteBehavior.SetNull);
            builder.HasMany(i => i.CarImages).WithOne(i => i.Car).HasForeignKey(i => i.CarId).OnDelete(DeleteBehavior.SetNull);
        }
    }
}
