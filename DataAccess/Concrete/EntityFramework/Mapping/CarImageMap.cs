using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Mapping
{
    public class CarImageMap : IEntityTypeConfiguration<CarImage>
    {
      
        public void Configure(EntityTypeBuilder<CarImage> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).UseIdentityColumn();

            builder.Property(i => i.ImagePath).IsRequired();
            builder.Property(i => i.Date).IsRequired();
        }
    }
}
