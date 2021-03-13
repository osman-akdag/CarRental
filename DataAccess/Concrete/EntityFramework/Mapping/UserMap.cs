using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EntityFramework.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).UseIdentityColumn();

            builder.Property(i => i.FirstName).IsRequired();
            builder.Property(i => i.LastName).IsRequired();
            builder.Property(i => i.Email).IsRequired();
            builder.Property(i => i.PasswordHash).IsRequired();
           
            builder.HasMany(i => i.UserOperationClaims).WithOne(i => i.User).HasForeignKey(i => i.UserId).OnDelete(DeleteBehavior.SetNull);

        }
    }
}
