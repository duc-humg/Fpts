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
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

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

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {

        }

        private void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {

        }

        private void TapGestureRecognizer_Tapped_4(object sender, EventArgs e)
        {

        }

        private void TapGestureRecognizer_Tapped_5(object sender, EventArgs e)
        {
            boxview.IsVisible = false;
            boxview1.IsVisible = false;
            boxview3.IsVisible = false;
            note.IsVisible = false;
        }

          private async void TapGestureRecognizer_Tapped_6(object sender, EventArgs e)
        {
            boxview.IsVisible = true;
            boxview1.IsVisible = true;
           
            boxview3.IsVisible = true;
            note.IsVisible = true;
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            check.IsVisible = true;
            entry.IsVisible = true;
            button.IsVisible = false;
        }

        private void TapGestureRecognizer_Tapped_7(object sender, EventArgs e)
        {
            check.IsVisible = false;
            entry.IsVisible = false;
            button.IsVisible = true;
            
        }
    }   
}
