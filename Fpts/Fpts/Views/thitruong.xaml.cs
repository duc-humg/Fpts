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

    public partial class thitruong : ContentPage
    {

        public thitruong()
        {
            InitializeComponent();
           this.BindingContext = new ViewModel.thitruongViewModel();
        }


        bool test = true;
        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            test = !test;
            var vm = (thitruongViewModel)BindingContext;
            if (list1.ItemsSource == vm.HNX)
            {
                foreach (var iteam in vm.HNX)
                {
                    if (test == true)
                    {
                        iteam.check1 = true;
                        iteam.check2 = false;
                        thaydoi1.Text = "Thay đổi";
                    }
                    else
                    {
                        iteam.check1 = false;
                        iteam.check2 = true;
                        thaydoi1.Text = "Thay đổi %";
                    }
                }
                list1.ItemsSource = vm.HSX;
                list1.ItemsSource = vm.HNX;
            }
            if (list1.ItemsSource == vm.HSX)
            {
                foreach (var item in vm.HSX)
                {
                    if (test == true)
                    {
                        item.check1 = true;
                        item.check2 = false;
                        thaydoi1.Text = "Thay đổi";
                    }
                    else
                    {
                        item.check1 = false;
                        item.check2 = true;
                        thaydoi1.Text = "Thay đổi %";
                    }
                }
                list1.ItemsSource = vm.HNX;
                list1.ItemsSource = vm.HSX;
            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            test = !test;
           
            var vn = (thitruongViewModel)BindingContext;
            if (list1.ItemsSource == vn.HNX)
            {
                foreach (var iteam in vn.HNX)
                {
                    if (test == true)
                    {
                        iteam.check3 = true;
                        iteam.check4 = false;
                        khoiluong.Text = "Khối Lượng";
                    }
                    else
                    {
                        iteam.check3 = false;
                        iteam.check4 = true;
                        khoiluong.Text = "Giá trị";
                    }
                }
                list1.ItemsSource = vn.HSX;
                list1.ItemsSource = vn.HNX;
            }
            if (list1.ItemsSource == vn.HSX)
            {
                foreach (var item in vn.HSX)
                {
                    if (test == true)
                    {
                        item.check3 = true;
                        item.check4 = false;
                        khoiluong.Text = "Khối Lượng";
                    }
                    else
                    {
                        item.check3 = false;
                        item.check4 = true;
                        khoiluong.Text = "Giá trị";
                    }
                }
                list1.ItemsSource = vn.HNX;
                list1.ItemsSource = vn.HSX;
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var vc = (thitruongViewModel)BindingContext;
            list1.ItemsSource = vc.HNX;
            bow1.IsVisible = true;
            bow2.IsVisible = false;
            btnHNX1.IsVisible = false;
            btnHSX1.IsVisible = true;
            
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            var vl = (thitruongViewModel)BindingContext;
            list1.ItemsSource = vl.HSX;
            bow1.IsVisible = false;
            bow2.IsVisible = true;
            btnHSX1.IsVisible = false;
            btnHNX1.IsVisible = true;
        }

        

        //public ICommand it

        private void btnHSX1_Clicked(object sender, EventArgs e)
        {

        }

        private void btnHNX1_Clicked(object sender, EventArgs e)
        {

        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            var vm = (thitruongViewModel)BindingContext;
            

        }

        private void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            
        }

       

        
    }
}