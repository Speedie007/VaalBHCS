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
   public partial class Address : VaalBeachClub.CustomeModel.BaseEntity
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected Address(): base()
      {
         Init();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="city"></param>
      /// <param name="suburb"></param>
      /// <param name="country"></param>
      /// <param name="areacode"></param>
      public Address(string city, string suburb, string country, string areacode)
      {
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
      /// <param name="city"></param>
      /// <param name="suburb"></param>
      /// <param name="country"></param>
      /// <param name="areacode"></param>
      public static Address Create(string city, string suburb, string country, string areacode)
      {
         return new Address(city, suburb, country, areacode);
      }

      /*************************************************************************
       * Persistent properties
       *************************************************************************/

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public string City { get; set; }

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public string Suburb { get; set; }

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public string Country { get; set; }

      /// <summary>
      /// Required
      /// </summary>
      [Required]
      public string AreaCode { get; set; }

   }
}

