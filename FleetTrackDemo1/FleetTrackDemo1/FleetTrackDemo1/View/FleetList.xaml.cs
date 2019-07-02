using FleetTrackDemo1.Model;
using FleetTrackDemo1.ViewModel;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FleetTrackDemo1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FleetList : ContentPage
    {
        FleetListViewModel fleetListViewModel;
        public FleetList()
        {
            
            try
            {
                InitializeComponent();

                fleetListViewModel = new FleetListViewModel();

                BindingContext = fleetListViewModel;
                if ((FleetListView.ItemsSource as List<Vehical>).Count == 0)
                {
                    FleetListView.IsVisible = false;
                    EmptyMessage.IsVisible = true;
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message + "  - " +e.ToString() +"    " + e);
            }
            finally
            {

                FleetListView.IsVisible = false;
                EmptyMessage.IsVisible = true;
            }
           
        }

        private void FleetListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            DisplayAlert("Item Selected", e.SelectedItem.ToString(), "Ok");
        }
    }
}