using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VaalBHCS.Models.BoatLockers
{
    public class BoatLockerModel
    {
        [Key]
        public int BoatLockerID { get; set; }
        public int BoatLockerNumber { get; set; }
        public string BoatLockerLocation { get; set; }
    }
}
