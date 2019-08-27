using FleetTrackApp.Services;
using FleetTrackApp.View;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Push;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FleetTrackApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LogIN();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            GeoLocationSet g;
            // Avoid duplicate event registration:
            if (!AppCenter.Configured)
            {
                Push.PushNotificationReceived += async (sender, e) =>
                {
                    DependencyService.Resolve<GeoLocationSet>();

                    //Add the notification message and title to the message
                   var summary = $"Push notification received:" +
                                       $"\n\tNotification title: {e.Title}" +
                                       $"\n\tMessage: {e.Message}";
                    g = new GeoLocationSet();
                    var msg = $"Push notification received:" +
                                        $"\n\tNotification title: {e.Title}" +
                                        $"\n\tMessage: {e.Message}";


                    //Fireing Event here
                    g.FireEvent();


                    //If there is custom data associated with the notification,
                    //print the entries
                    if (e.CustomData != null)
                    {
                        summary += "\n\tCustom data:\n";
                        foreach (var key in e.CustomData.Keys)
                        {
                            summary += $"\t\t{key} : {e.CustomData[key]}\n";
                        }
                        msg += "\n Latitude : " + g.Latitude.ToString();

                        msg += "\n Longititude : " + g.Longititude.ToString();

                    }

                    //Send the notification summary to debug output
                    System.Diagnostics.Debug.WriteLine(msg);
                };
            }

            // AppCenter.start            
            AppCenter.Start("android=5781d50e-3ade-40c5-bb02-ede87b549081;" +
                  "uwp={Your UWP App secret here};" +
                  "ios={Your iOS App secret here}", typeof(Push));
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
