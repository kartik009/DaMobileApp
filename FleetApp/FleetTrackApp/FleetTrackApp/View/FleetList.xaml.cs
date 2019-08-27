using FleetTrackApp.Model;
using FleetTrackApp.ViewModel;
using Newtonsoft.Json;
using Plugin.Geolocator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FleetTrackApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FleetList : ContentPage
    {
        //FleetListViewModel fleetListViewModel;

        public FleetList(List<FleetData> f)
        {
            InitializeComponent();
            if (f.Count == 0)
            {
                VehicalList.IsVisible = false;
                EmptyMsg.IsVisible = true;
            }
            else
            {
                VehicalList.ItemsSource = f;
            }
        }

        //public FleetList()
        //{
        //    InitializeComponent();
        //    //fleetListViewModel = new FleetListViewModel();


        //    //if (fleetListViewModel.Fleets.Count == 0)
        //    //{
        //    //    VehicalList.IsVisible = false;
        //    //    EmptyMsg.IsVisible = true;
        //    //}
        //    //else
        //    //{
        //    //    VehicalList.ItemsSource = fleetListViewModel.Fleets;
        //    //}

        //}

        private void VehicalList_ItemTapped(object sender, ItemTappedEventArgs e)
        {

            //if (Device.RuntimePlatform == Device.Android)
            //{
            //    //Getting Location Of device
            //    var locator = CrossGeolocator.Current;
            //    locator.DesiredAccuracy = 50;

            //    var position = await locator.GetPositionAsync(timeout: TimeSpan.FromMilliseconds(10000));

            //}

            ////Send Location to web APi
            //using (HttpClient client = new HttpClient())
            //{
            //    client.BaseAddress = new Uri("APi Key For Post");

            //    client.DefaultRequestHeaders.Accept.Clear();


            //    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            //    var uri = new Uri("http://192.162.125.3:80/Fleet/api/Location/Post");

            //    LocationInfo locationInfo = new LocationInfo();

            //    locationInfo.FleetID = 2;

            //    locationInfo.Latitude = Convert.ToDecimal(position.Latitude);

            //    locationInfo.Longitude = Convert.ToDecimal(position.Longitude);

            //    string serializedObject = JsonConvert.SerializeObject(locationInfo);

            //    try
            //    {
            //        var content = new StringContent(serializedObject, Encoding.UTF8, "application/json");
            //        HttpResponseMessage response = await client.PostAsync(uri, content);

            //        var result = await response.Content.ReadAsStringAsync();

            //    }
            //    catch (Exception ex)
            //    {

            //        Console.WriteLine("Big Error " + ex);
            //    }

            //}

            //Vehical v = e.Item as Vehical;

            Navigation.PushModalAsync(new FinalFleet((e.Item as FleetData).FleetRCNo.ToString()));
        }
    }
}