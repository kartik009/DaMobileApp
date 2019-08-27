using FleetTrackApp.Model;
using Newtonsoft.Json;
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
    public partial class LogIN : ContentPage
    {
        public LogIN()
        {
            InitializeComponent();
        }


        private async void Btn_Login_Clicked(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {

                    var response = await client.GetStringAsync("http://192.168.0.101:5252/api/owner");

                    var response2 = await client.GetStringAsync("http://192.168.2.1:5253/api/fleet");

                    var DataModel = JsonConvert.DeserializeObject<List<OwnerData>>(response);

                    var Fleets = JsonConvert.DeserializeObject<List<FleetData>>(response2);

                    //Custome code here 
                    if (DataModel.Any(s => s.OwnerEmail.ToLower().ToString() == et_user.Text.ToLower().ToString()) && DataModel.Any(s => s.Ownerpass.ToString() == et_pass.Text.ToString()))
                    {
                         //Navigation.PushModalAsync(new FleetList());
                        Navigation.PushModalAsync(new FleetList(Fleets));
                    }
                    else
                    {
                        DisplayAlert("FleetApp", "Wrong Password or Username", "OK");
                        
                    }
                }
                catch (Exception ex)
                {
                    DisplayAlert("FleetApp", "Something went Wrong!", "OK");
                    Console.WriteLine("Big Error " + ex);
                }

            }

            //Navigation.PushModalAsync(new FleetList());

        }
    }
}