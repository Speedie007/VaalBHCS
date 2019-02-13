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
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;

namespace VaalBeachClub.Web.Data.Identity
{
   public partial class BeachClubRole : IdentityRole<int>
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected BeachClubRole()
      {
         UserRoles = new System.Collections.ObjectModel.Collection<VaalBeachClub.Web.Data.Identity.BeachClubUserRole>();
         RoleClaims = new System.Collections.ObjectModel.Collection<VaalBeachClub.Web.Data.Identity.BeachClubRoleClaim>();

         Init();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="_beachclubuserrole0"></param>
      /// <param name="_beachclubroleclaim1"></param>
      public BeachClubRole(VaalBeachClub.Web.Data.Identity.BeachClubUserRole _beachclubuserrole0, VaalBeachClub.Web.Data.Identity.BeachClubRoleClaim _beachclubroleclaim1)
      {
         if (_beachclubuserrole0 == null) throw new ArgumentNullException(nameof(_beachclubuserrole0));
         _beachclubuserrole0.Role = this;

         if (_beachclubroleclaim1 == null) throw new ArgumentNullException(nameof(_beachclubroleclaim1));
         _beachclubroleclaim1.Role = this;

         UserRoles = new System.Collections.ObjectModel.Collection<VaalBeachClub.Web.Data.Identity.BeachClubUserRole>();
         RoleClaims = new System.Collections.ObjectModel.Collection<VaalBeachClub.Web.Data.Identity.BeachClubRoleClaim>();
         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="_beachclubuserrole0"></param>
      /// <param name="_beachclubroleclaim1"></param>
      public static BeachClubRole Create(VaalBeachClub.Web.Data.Identity.BeachClubUserRole _beachclubuserrole0, VaalBeachClub.Web.Data.Identity.BeachClubRoleClaim _beachclubroleclaim1)
      {
         return new BeachClubRole(_beachclubuserrole0, _beachclubroleclaim1);
      }

      /*************************************************************************
       * Persistent properties
       *************************************************************************/

      /// <summary>
      /// Identity, Required, Indexed
      /// </summary>
      [Key]
      [Required]
      public int Id { get; set; }

      /*************************************************************************
       * Persistent navigation properties
       *************************************************************************/

      public virtual ICollection<VaalBeachClub.Web.Data.Identity.BeachClubUserRole> UserRoles { get; set; }

      public virtual ICollection<VaalBeachClub.Web.Data.Identity.BeachClubRoleClaim> RoleClaims { get; set; }

   }
}

