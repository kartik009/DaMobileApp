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