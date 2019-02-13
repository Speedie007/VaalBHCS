using System;
using System.Collections.Generic;
using System.Text;

namespace VaalBeachClub.Models.Domain.Rentals
{
    public partial class CampSiteRental:BaseEntity
    {
        public CampSiteRental()
        {

        }


        public virtual string CampSiteNumber { get; set; }
    }
}
