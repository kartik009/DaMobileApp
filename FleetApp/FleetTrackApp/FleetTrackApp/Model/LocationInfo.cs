using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FleetTrackApp.Model
{
    public class LocationInfo
    {
       
        public int LocationID { get; set; }
        
        public int FleetID { get; set; }

     
        public decimal Latitude { get; set; }

       
        public decimal Longitude { get; set; }

    }
}
