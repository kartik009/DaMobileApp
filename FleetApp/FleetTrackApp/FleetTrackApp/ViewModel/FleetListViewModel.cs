using FleetTrackApp.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace FleetTrackApp.ViewModel
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
