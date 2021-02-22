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
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Fpts.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class PageThiTruongViewModel : ContentPage
    {

        public PageThiTruongViewModel()
        {
            InitializeComponent();
           this.BindingContext = new ViewModel.PageThiTruongViewModel();
            
        }


        private bool test = true;
        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            test = !test;
            var vm = (ViewModel.PageThiTruongViewModel)BindingContext;
            if (listHNX.ItemsSource == vm.HNX)
            {
                foreach (var iteam in vm.HNX)
                {
                    if (test == true)
                    {
                        iteam.CheckThayDoiOne = true;
                        iteam.CheckThayDoiTow = false;
                        lblThayDoi.Text = "Thay đổi";
                    }
                    else
                    {
                        iteam.CheckThayDoiOne = false;
                        iteam.CheckThayDoiTow = true;
                        lblThayDoi.Text = "Thay đổi %";
                    }
                }
                listHNX.ItemsSource = vm.HSX;
                listHNX.ItemsSource = vm.HNX;
            }
            if (listHNX.ItemsSource == vm.HSX)
            {
                foreach (var item in vm.HSX)
                {
                    if (test == true)
                    {
                        item.CheckThayDoiOne = true;
                        item.CheckThayDoiTow = false;
                        lblThayDoi.Text = "Thay đổi";
                    }
                    else
                    {
                        item.CheckThayDoiOne = false;
                        item.CheckThayDoiTow = true;
                        lblThayDoi.Text = "Thay đổi %";
                    }
                }
                listHNX.ItemsSource = vm.HNX;
                listHNX.ItemsSource = vm.HSX;
            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            test = !test;
           
            var vn = (ViewModel.PageThiTruongViewModel)BindingContext;
            if (listHNX.ItemsSource == vn.HNX)
            {
                foreach (var iteam in vn.HNX)
                {
                    if (test == true)
                    {
                        iteam.CheckShowKhoiLuong = true;
                        iteam.CheckShowGia = false;
                        lblKhoiLuong.Text = "Khối Lượng";
                    }
                    else
                    {
                        iteam.CheckShowKhoiLuong = false;
                        iteam.CheckShowGia = true;
                        lblKhoiLuong.Text = "Giá trị";
                    }
                }
                listHNX.ItemsSource = vn.HSX;
                listHNX.ItemsSource = vn.HNX;
            }
            if (listHNX.ItemsSource == vn.HSX)
            {
                foreach (var item in vn.HSX)
                {
                    if (test == true)
                    {
                        item.CheckShowKhoiLuong = true;
                        item.CheckShowGia = false;
                        lblKhoiLuong.Text = "Khối Lượng";
                    }
                    else
                    {
                        item.CheckShowKhoiLuong = false;
                        item.CheckShowGia = true;
                        lblKhoiLuong.Text = "Giá trị";
                    }
                }
                listHNX.ItemsSource = vn.HNX;
                listHNX.ItemsSource = vn.HSX;
            }
        }

        //public ICommand it

        private void btnHSX1_Clicked(object sender, EventArgs e)
        {
            var vc = (ViewModel.PageThiTruongViewModel)BindingContext;
            listHNX.ItemsSource = vc.HNX;
            boxHSX.IsVisible = true;
            boxHNX.IsVisible = false;
            btnHNX1.IsVisible = false;
            btnHSX1.IsVisible = true;
            App.test = true;
        }

        private void btnHNX1_Clicked(object sender, EventArgs e)
        {
            var vl = (ViewModel.PageThiTruongViewModel)BindingContext;
            listHNX.ItemsSource = vl.HSX;
            boxHSX.IsVisible = false;
            boxHNX.IsVisible = true;
            btnHSX1.IsVisible = false;
            btnHNX1.IsVisible = true;
            App.test = false;
        }

        private void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            
        }

        private void TapGestureRecognizer_Tapped1(object sender, EventArgs e)
        {
            test = !test;
            var vm = (ViewModel.PageThiTruongViewModel)BindingContext;
            if (listHNX.ItemsSource == vm.HNX)
            {
                foreach (var iteam in vm.HNX)
                {
                    if (test == true)
                    {
                        iteam.CheckThayDoiOne = true;
                        iteam.CheckThayDoiTow = false;
                        lblThayDoi.Text = "Thay đổi";
                    }
                    else
                    {
                        iteam.CheckThayDoiOne = false;
                        iteam.CheckThayDoiTow = true;
                        lblThayDoi.Text = "Thay đổi %";
                    }
                }
                listHNX.ItemsSource = vm.HSX;
                listHNX.ItemsSource = vm.HNX;
            }
            if (listHNX.ItemsSource == vm.HSX)
            {
                foreach (var item in vm.HSX)
                {
                    if (test == true)
                    {
                        item.CheckThayDoiOne = true;
                        item.CheckThayDoiTow = false;
                        lblThayDoi.Text = "Thay đổi";
                    }
                    else
                    {
                        item.CheckThayDoiOne = false;
                        item.CheckThayDoiTow = true;
                        lblThayDoi.Text = "Thay đổi %";
                    }
                }
                listHNX.ItemsSource = vm.HNX;
                listHNX.ItemsSource = vm.HSX;
            }
        }
    }
}