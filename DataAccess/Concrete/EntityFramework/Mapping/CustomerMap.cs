using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EntityFramework.Mapping
{
    public class CustomerMap : IEntityTypeConfiguration<Customer>  
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).UseIdentityColumn();

            builder.HasMany(i => i.Rentals).WithOne(i => i.Customer).HasForeignKey(i => i.CustomerId).OnDelete(DeleteBehavior.SetNull);
        }
    }
}
