using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using VaalBeachClub.Models.Domain.Rentals;
using VaalBeachClub.Web.Data.Identity;

namespace VaalBeachClub.Data.Mapping.BoatHouses
{
    class BoatHouseRentalDbMapping : BeachClubEntityTypeConfiguration<BoatHouseRental>
    {
        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<BoatHouseRental> builder)
        {

            builder.ToTable("BoatHouseRentals");

            builder.HasKey(boathouse => boathouse.Id);

            builder.Property(x => x.Id)
                .HasColumnName("BoatHouseRentalID");

           
            base.Configure(builder);
        }

        public override void ApplyConfiguration(ModelBuilder modelBuilder)
        {
            base.ApplyConfiguration(modelBuilder);


        }

    }
}

  