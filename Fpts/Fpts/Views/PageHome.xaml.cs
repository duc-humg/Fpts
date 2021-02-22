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
            BindingContext = new PageHomeViewModel();
        }
        private bool test = true;

        async private void Tap_thitruong(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageThiTruongViewModel());
        }
        private void Tap_listDanhMuc(object sender, EventArgs e)
        {
            boxBongmo.IsVisible = true;
            boxDuongke.IsVisible = true;
            boxView3.IsVisible = true;
            griDanhMuc.IsVisible = true;
            check.IsVisible = false;
            entry.IsVisible = false;
            button.IsVisible = true;
        }
        private void Tap_chuyentanggiam(object sender, EventArgs e)
        {
            test = !test;
            var test1 = (PageHomeViewModel)BindingContext;

            if (test == true)
            {
                lblToantu.Text = "+/-(%)";
            }
            else
            {
                lblToantu.Text = "+/-";
            }

            foreach (var item in test1.ListMaChungKhoan)
            {
                if (test == false)
                {
                    item.CheckTangGiamTow = true;
                    item.CheckTangGiamOne = false;
                }
                else
                {
                    item.CheckTangGiamTow = false;
                    item.CheckTangGiamOne = true;
                }
            }
            listMaChungKhoan.ItemsSource = "";
            listMaChungKhoan.ItemsSource = test1.ListMaChungKhoan;
        }
        private void Tap_tatlistDanhMuc(object sender, EventArgs e)
        {
            boxBongmo.IsVisible = false;
            boxDuongke.IsVisible = false;
            boxView3.IsVisible = false;
            griDanhMuc.IsVisible = false;
            entry.Text = "";
        }

        async private void Tap_taoDanhMuc(object sender, EventArgs e)
        {
            var vm = (PageHomeViewModel)BindingContext;
            int i = 0;
            foreach (var itim in vm.ListTaoDanhMuc)
            {
                if (entry.Text == itim.NameDanhMuc)
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
                vm.ListTaoDanhMuc.Add(new DanhMucModel { NameDanhMuc = entry.Text, Image = "kiemtra.png" });
            }
            else
            {
                check.IsVisible = false;
                entry.IsVisible = false;
                button.IsVisible = true;

            }
            entry.Text = "";
        }

        private void Button_TaoDanhMuc(object sender, EventArgs e)
        {
            check.IsVisible = true;
            entry.IsVisible = true;
            button.IsVisible = false;
            entry.Focus();
        }
    }
}
