using FleetTrackApp.Model;
using Newtonsoft.Json;
using Plugin.Geolocator;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FleetTrackApp.Services
{
    public class GeoLocationSet
    {
        private const double V = 37.4220;
        private const double V1 = 45.2000;

        public decimal Latitude { get; set; }

        public decimal Longititude { get; set; }

        public GeoLocationSet()
        {
            Latitude = Convert.ToDecimal(V);
            Longititude = Convert.ToDecimal(V1);
        }

        public async void FireEvent()
        {

            //Send Location to web APi
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("APi Key For Post");

                client.DefaultRequestHeaders.Accept.Clear();


                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                var uri = new Uri("http://192.162.125.3:80/Fleet/api/Location/Post");

                LocationInfo locationInfo = new LocationInfo();

                locationInfo.FleetID = 2;

                //Getting Location Of device
                if (Device.RuntimePlatform == Device.Android)
                {

                    var locator = CrossGeolocator.Current;
                    locator.DesiredAccuracy = 50;

                    var position = await locator.GetPositionAsync(timeout: TimeSpan.FromMilliseconds(10000));

                    locationInfo.Latitude = Convert.ToDecimal(position.Latitude);

                    //Latitude = Convert.ToDecimal(position.Latitude);

                    locationInfo.Longitude = Convert.ToDecimal(position.Longitude);

                    //Longititude = Convert.ToDecimal(position.Longitude);

                }

                string serializedObject = JsonConvert.SerializeObject(locationInfo);

                try
                {
                    var content = new StringContent(serializedObject, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(uri, content);

                    var result = await response.Content.ReadAsStringAsync();

                }
                catch (Exception ex)
                {

                    Console.WriteLine("Big Error " + ex);
                }

            }
        }
    }
}
