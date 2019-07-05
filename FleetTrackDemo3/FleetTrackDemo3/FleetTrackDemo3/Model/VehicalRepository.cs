using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FleetTrackDemo3.Model
{
    public class VehicalRepository 
    {
        public ObservableCollection<Vehical> vehicals { get; set; }

        public VehicalRepository()
        {
            LoadData();
        }

        private void LoadData()
        {
            if(vehicals == null)
            {
                    vehicals = new ObservableCollection<Vehical>() {
                            new Vehical { RCNo = "Gj 05 LK 5360" },
                            new Vehical { RCNo = "Gj 01 LM 5860" }
                    };
            }
        }

    }
}
