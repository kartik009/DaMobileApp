using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FleetTrackDemo1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogIN : ContentPage
    {
        public LogIN()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new FleetList());
        }
    }
}