using FleetTrackApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FleetTrackApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FinalFleet : ContentPage
    {
        public FinalFleet(string v)
        {
            InitializeComponent();
            FleetName.Text ="Tic Tak Track "+ v.ToString();
        }
    }
}