//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
//
//     Produced by Entity Framework Visual Editor
//     https://github.com/msawczyn/EFDesigner
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VaalBHCSSystem.DataClass
{
   /// <inheritdoc/>
   public partial class MyModel : Microsoft.EntityFrameworkCore.DbContext
   {
      #region DbSets
      public virtual Microsoft.EntityFrameworkCore.DbSet<VaalBHCSSystem.DataClass.BoatHouse> BoatHouses { get; set; }
      public virtual Microsoft.EntityFrameworkCore.DbSet<VaalBHCSSystem.DataClass.House> Houses { get; set; }
      #endregion DbSets

      /// <inheritdoc />
      public MyModel() : base()
      {
      }

      /// <inheritdoc />
      public MyModel(DbContextOptions<MyModel> options) : base(options)
      {
      }

      partial void CustomInit(DbContextOptionsBuilder optionsBuilder);

      /// <inheritdoc />
      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
         CustomInit(optionsBuilder);
      }

      partial void OnModelCreatingImpl(ModelBuilder modelBuilder);
      partial void OnModelCreatedImpl(ModelBuilder modelBuilder);

      /// <inheritdoc />
      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
         base.OnModelCreating(modelBuilder);
         OnModelCreatingImpl(modelBuilder);

         modelBuilder.HasDefaultSchema("dbo");


         modelBuilder.Entity<VaalBHCSSystem.DataClass.House>()
                     .ToTable("Houses")
                     .HasKey(t => t.Id);
         modelBuilder.Entity<VaalBHCSSystem.DataClass.House>()
                     .Property(t => t.Id)
                     .IsRequired()
                     .ValueGeneratedOnAdd();

         OnModelCreatedImpl(modelBuilder);
      }
   }
}
