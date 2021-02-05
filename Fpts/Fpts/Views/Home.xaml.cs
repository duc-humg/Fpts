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
           
            if (test == true)
            {
                lbltoantu.Text = "+/-(%)";
            }
            else 
            {
                lbltoantu.Text = "+/-";
            }
                
            foreach(var item in test1.Giaodich)
            {
                if (test == false)
                {
                    item.check7 = true;
                    item.check6 = false;
                }
                else
                {
                    item.check7 = false;
                    item.check6 = true;
                }
            }
            list2.ItemsSource = "";
            list2.ItemsSource = test1.Giaodich;

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
            entry.Text = "";

        }

          private void TapGestureRecognizer_Tapped_6(object sender, EventArgs e)
        {
            boxview.IsVisible = true;
            boxview1.IsVisible = true;
           
            boxview3.IsVisible = true;
            note.IsVisible = true;
            check.IsVisible = false;
            entry.IsVisible = false;
            button.IsVisible = true;

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            check.IsVisible = true;
            entry.IsVisible = true;
            button.IsVisible = false;
            entry.Focus();
        }

        private async void TapGestureRecognizer_Tapped_7(object sender, EventArgs e)
        {
            
            var vm = (HomeViewModel)BindingContext;
            int i = 0;
            foreach(var itim in vm.listnote)
            {
                if (entry.Text == itim.notetext)
                {
                    await DisplayAlert("Success", "Your data are saved", "Ok");
                    i = 1;
                }
            }
            if (entry.Text != "" && i != 1)
            {
                check.IsVisible = false;
                entry.IsVisible = false;
                button.IsVisible = true;
                vm.listnote.Add(new note { notetext = entry.Text, image = "kiemtra.png" });
            }
            else
            {
                check.IsVisible = false;
                entry.IsVisible = false;
                button.IsVisible = true;

            }
           
            entry.Text = "";
                
        }

        
    }
}
