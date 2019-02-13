using System;
using System.Collections.Generic;
using System.Text;

namespace VaalBeachClub.Models.Domain.StorageItems
{
    public abstract partial class StorageItem : BaseEntity
    {

        public StorageItem()
        {

        }

        public Boolean IsCurrentlyInStorage { get; set; }
        public StorageItemType StorageItemType { get; set; }

    }
    public partial class Boat : StorageItem
    {
        public string BoatModel { get; set; }
        public string BoatMake { get; set; }
        public string BoatRegistration { get; set; }
    }

    public partial class Trailer : StorageItem
    {
       
        public string TrailerRegistration { get; set; }
    }
    public partial class JetSki : StorageItem
    {

        public string JetSkiModel { get; set; }
        public string JetSkiMake { get; set; }
        public string JetSkiRegistration { get; set; }
    }
    public enum StorageItemType
    {
        Boat, Trailer, JetSki
    }
}
