using Fpts.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fpts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailMainviewMaster : ContentPage
    {
        public ListView ListView;

        public MasterDetailMainviewMaster()
        {
            InitializeComponent();
            
            BindingContext = new ViewXulyTuongTacViewModel();
            
        }
        
        public bool test;
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            
            var vm = (ViewXulyTuongTacViewModel)BindingContext;
            
            foreach(var item in vm.ListTuongTac)
            {
                if (test == false)
                {
                    listTuongTac.ItemsSource = vm.ListTuongTac;
                    item.CheckSao = true;
                    item.CheckNutThemSuKien = true;
                    item.CheckSuKienKeoDai = false;
                    setup.IsVisible = false;
                    power.IsVisible = false;
                    tick.IsVisible = true;
                    
                }
            }
        }
        
        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
           
            var vm = (ViewXulyTuongTacViewModel)BindingContext;

            foreach (var item in vm.ListTuongTac)
            {
                if ( App.test1==true)
                {
                    item.CheckSao = false;
                    item.CheckSuKienKeoDai = true;
                    item.CheckNutThemSuKien = true;
                    setup.IsVisible = true;
                    power.IsVisible = true;
                    tick.IsVisible = false;
                    listTuongTac.ItemsSource = vm.ListThayThe;
                }
                if ( App.test1 == false)
                {
                    item.CheckSao = false;
                    item.CheckSuKienKeoDai = true;
                    setup.IsVisible = true;
                    power.IsVisible = true;
                    tick.IsVisible = false;
                    listTuongTac.ItemsSource = vm.ListTuongTac;
                }
            }
        }

        async private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            await App.Current.MainPage.DisplayAlert("Thông báo", "Bạn có muốn đăng xuất không ?", "Hủy", "Đăng xuất");
        }
    }
}
    