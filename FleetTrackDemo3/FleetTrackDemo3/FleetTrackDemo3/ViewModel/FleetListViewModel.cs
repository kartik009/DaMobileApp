using FleetTrackDemo3.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace FleetTrackDemo3.ViewModel
{
    public class FleetListViewModel
    {
        private readonly VehicalRepository vehicalRepository;

        public ObservableCollection<Vehical> Fleets { get; set; }

        public FleetListViewModel()
        {
            vehicalRepository = new VehicalRepository();
            Fleets = vehicalRepository.vehicals;
        }

    }
}
