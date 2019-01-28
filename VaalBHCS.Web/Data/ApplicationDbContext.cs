using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VaalBHCS.Models.BoatLockers;

namespace VaalBHCS.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<VaalBHCS.Models.BoatLockers.BoatLockerModel> BoatLockerModel { get; set; }
    }
}
