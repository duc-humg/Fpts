using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Fpts.Views.core
{
    public class BaseContentPage : ContentPage
    {
        public void SendAppearing()
        {
            OnAppearing();
        }

        public void SendDisappearing()
        {
            OnDisappearing();
        }
    }
}
