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

namespace VaalBeachClub.Models.Domain.Addresses
{
   public partial class POBoxAddress : VaalBeachClub.Models.Domain.Addresses.Address
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected POBoxAddress(): base()
      {
         Init();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="poboxnumber"></param>
      /// <param name="city"></param>
      /// <param name="suburb"></param>
      /// <param name="country"></param>
      /// <param name="areacode"></param>
      public POBoxAddress(string poboxnumber, string city, string suburb, string country, string areacode)
      {
         if (string.IsNullOrEmpty(poboxnumber)) throw new ArgumentNullException(nameof(poboxnumber));
         POBoxNumber = poboxnumber;
         if (string.IsNullOrEmpty(city)) throw new ArgumentNullException(nameof(city));
         City = city;
         if (string.IsNullOrEmpty(suburb)) throw new ArgumentNullException(nameof(suburb));
         Suburb = suburb;
         if (string.IsNullOrEmpty(country)) throw new ArgumentNullException(nameof(country));
         Country = country;
         if (string.IsNullOrEmpty(areacode)) throw new ArgumentNullException(nameof(areacode));
         AreaCode = areacode;
         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="poboxnumber"></param>
      /// <param name="city"></param>
      /// <param name="suburb"></param>
      /// <param name="country"></param>
      /// <param name="areacode"></param>
      public static POBoxAddress Create(string poboxnumber, string city, string suburb, string country, string areacode)
      {
         return new POBoxAddress(poboxnumber, city, suburb, country, areacode);
      }

      /*************************************************************************
       * Persistent properties
       *************************************************************************/

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public string POBoxNumber { get; set; }

   }
}

