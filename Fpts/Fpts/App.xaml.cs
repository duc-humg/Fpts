using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fpts
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MasterDetailMainview();
        }
        public static bool test=true;
        public static bool test1;

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
