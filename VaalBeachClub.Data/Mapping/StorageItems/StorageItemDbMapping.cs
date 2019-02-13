using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using VaalBeachClub.Models.Domain.StorageItems;

namespace VaalBeachClub.Data.Mapping.StorageItems
{
    public partial class StorageItemDbMapping : BeachClubEntityTypeConfiguration<StorageItem>
    {
        public override void Configure(EntityTypeBuilder<StorageItem> builder)
        {

            builder.Property(x => x.Id)
                 .HasColumnName("StorageItemID");

            builder.ToTable("StorageItems");




            base.Configure(builder);
        }

        public override void ApplyConfiguration(ModelBuilder modelBuilder)
        {
            base.ApplyConfiguration(modelBuilder);


        }
    }
}
