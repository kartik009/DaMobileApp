using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FleetTrackApp.Model
{
  
    public class OwnerData
    {
        public long OwnerId { get; set; }

     
        public string OwnerName { get; set; }

     
        public long OwnerContact { get; set; }

     
        public string OwnerEmail { get; set; }

   
        public string Ownerpass { get; set; }

       //public ICollection<FleetData> Fleets { get; set; } = new List<FleetData>();
    }
}
