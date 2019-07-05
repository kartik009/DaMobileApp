using FleetTrackDemo3.Model;
using FleetTrackDemo3.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FleetTrackDemo3.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FleetList : ContentPage
    {
        FleetListViewModel fleetListViewModel;
        public FleetList()
        {
            InitializeComponent();
            fleetListViewModel = new FleetListViewModel();
                       

            //if(fleetListViewModel.Fleets.Count ==0)
            //{
            //    VehicalList.IsVisible = false;
            //    EmptyMsg.IsVisible = true;
            //}
            //else
            //{
                VehicalList.ItemsSource = fleetListViewModel.Fleets;
            

        }

        private void VehicalList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //Vehical v = e.Item as Vehical;
            Navigation.PushModalAsync(new FinalFleet((e.Item as Vehical).RCNo.ToString()));
        }
    }
}