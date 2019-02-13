using System;
using System.Collections.Generic;
using System.Text;

namespace VaalBeachClub.Models.Domain.BoatHouses
{
    public partial class BoatHouseSize : BaseEntity
    {
        public virtual Int64 Size { get; set; }
        public virtual BoatHouse BoatHouse { get; set; }

    }
}
