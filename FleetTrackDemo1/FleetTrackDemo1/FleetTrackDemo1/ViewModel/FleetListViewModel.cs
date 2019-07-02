using FleetTrackDemo1.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace FleetTrackDemo1.ViewModel
{
    public class FleetListViewModel
    {
        public ObservableCollection<Vehical> Fleets { get; set; }

        public List<Vehical> v = new List<Vehical>()
        {
            new Vehical{   RCNo = "Gj 05 LK 5360" },
            new Vehical{RCNo = "Gj 01 LM 5860"}
        };

        public FleetListViewModel()
        {
            Fleets = new ObservableCollection<Vehical>();
            foreach (Vehical vehical in v)
                Fleets.Add(vehical);

        }

    }
}
