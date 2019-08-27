using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FleetTrackApp.Model
{
    public class FleetData
    {
       
        public long FleetID { get; set; }

     
        public string FleetRCNo { get; set; }

      
        public string FleetType { get; set; }

        public string CompanyName { get; set; }

        //[ForeignKey("OwnerId")]
       // public OwnerData Owner { get; set; }

        public long OwnerId { get; set; }
    }
}
