using Fpts.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fpts.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
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
            if (list1.ItemsSource == HNX)
            {
                foreach (var iteam in HNX)
                {
                    if (test == true)
                    {
                        iteam.check1 = true;
                        iteam.check2 = false;
                    }
                    else
                    {
                        iteam.check1 = false;
                        iteam.check2 = true;
                    }
                }
                list1.ItemsSource = HSX;
                list1.ItemsSource = HNX;
            }
            if (list1.ItemsSource == HSX)
            {
                foreach (var item in HSX)
                {
                    if (test == true)
                    {
                        item.check1 = true;
                        item.check2 = false;
                    }
                    else
                    {
                        item.check1 = false;
                        item.check2 = true;
                    }
                }
                list1.ItemsSource = HNX;
                list1.ItemsSource = HSX;
            }
        }
    }
}