using Fpts.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Fpts.Models;

namespace Fpts.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public static Page HomeViews;
        public Home()
        {
            InitializeComponent();
            BindingContext = new HomeViewModel();
           
            
        }
        bool test = true;

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new thitruong());
        }


        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            test = !test;
            var test1 = (HomeViewModel)BindingContext;
            test1.IsSessionExpried = !test1.IsSessionExpried;
            if (test == true)
            {
                lbltoantu.Text = "+/-(%)";
            }
            else
                lbltoantu.Text = "+/-";



        }
    }   
}
