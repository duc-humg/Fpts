using Fpts.Models;
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
    public partial class Datlenh : ContentPage
    {
        public int c;
        public int a;
        public int b = 500;
        public Datlenh()
        {
            InitializeComponent();
            BindingContext = new datlenhViewmodel();


        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            entry1.Text = "";
            lbl_ten.Text = "";
            lbl_TC.Text = "0";
            lbl_san.Text = "0";
            lbl_mua1.Text = "0";
            lbl_tran.Text = "0";
            lbl_khop.Text = "0";
            lbl_ban1.Text = "0";
            entry_KL.Text = "";
            lbl_gia.Text = "";
            lbl_max.IsVisible = false;
            lbl_mua.IsVisible = true;
            lbl_ban.IsVisible = false;
            btn_mua.Text = "xác nhận mua";
            btn_mua.IsVisible = true;
            btn_ban.IsVisible = false;
            btn_ban1.IsVisible = false;
            btn_mua1.IsVisible = false;
            btn_mua2.IsVisible = false;
            xl_gia.IsVisible = false;

        }

        async private void entry1_Unfocused(object sender, FocusEventArgs e)
        {
            if (entry1.Text == "" || entry1.Text == null)
            {
                entry_KL.IsEnabled = false;
                lbl_ten.Text = "";
                lbl_TC.Text = "0";
                lbl_san.Text = "0";
                lbl_mua1.Text = "0";
                lbl_tran.Text = "0";
                lbl_khop.Text = "0";
                lbl_ban1.Text = "0";
            }
            if (entry1.Text != "" && entry1.Text != null)
            {
                var mn = (datlenhViewmodel)BindingContext;
                mn.ma = entry1.Text.ToUpper();//viết hoa lên
                foreach (var item in mn.listlenh)
                {
                    if (mn.ma == item.ma1)
                    {
                        c = 1;
                        mn.tenct = item.tenct1;
                        mn.tran = item.tran1;
                        mn.TC = item.TC1;
                        mn.san = item.san1;
                        mn.mua1 = item.mua11;
                        mn.khop = item.khop1;
                        mn.ban1 = item.ban11;
                        xl_gia.IsVisible = true;
                        lbl_ten.Text = mn.tenct;
                        lbl_TC.Text = mn.TC;
                        lbl_san.Text = mn.san;
                        lbl_mua1.Text = mn.mua1;
                        lbl_tran.Text = mn.tran;
                        lbl_khop.Text = mn.khop;
                        lbl_ban1.Text = mn.ban1;
                        lbl_max.IsVisible = true;
                        break;
                    }
                    else
                    {
                        c = 2;
                    }

                }
                if (c != 1)
                {
                    await DisplayAlert("Thông báo", "Mã chứng khoán không tồn tại", "ok");
                    entry1.Text = "";
                }
            }


        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            if (lbl_mua.IsVisible == true)
            {
                lbl_mua.IsVisible = false;
                lbl_ban.IsVisible = true;
                text1.IsVisible = false;
                text2.IsVisible = true;
                btn_mua.IsVisible = true;
                btn_ban.IsVisible = false;
                btn_ban1.IsVisible = false;
                btn_mua1.IsVisible = false;
                btn_mua2.IsVisible = false;

                entry_KL.Text = "";
                lbl_gia.Text = "";
                btn_mua.Text = "Xác nhận bán";
            }
            else
            {
                lbl_mua.IsVisible = true;
                lbl_ban.IsVisible = false;
                text1.IsVisible = true;
                text2.IsVisible = false;
                btn_mua.IsVisible = true;
                btn_ban.IsVisible = false;
                btn_ban1.IsVisible = false;
                btn_mua1.IsVisible = false;
                btn_mua2.IsVisible = false;

                btn_mua.Text = "Xác nhận mua";
                entry_KL.Text = "";
                lbl_gia.Text = "";
            }

        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            if (lbl_mua.IsVisible == true)
            {
                lbl_mua.IsVisible = false;
                lbl_ban.IsVisible = true;
                text1.IsVisible = false;
                text2.IsVisible = true;
                btn_mua.IsVisible = true;
                btn_ban.IsVisible = false;
                btn_ban1.IsVisible = false;
                btn_mua1.IsVisible = false;
                btn_mua2.IsVisible = false;

                entry_KL.Text = "";
                lbl_gia.Text = "";
                btn_mua.Text = "Xác nhận bán";
            }
            else
            {
                lbl_mua.IsVisible = true;
                lbl_ban.IsVisible = false;
                text1.IsVisible = true;
                text2.IsVisible = false;
                btn_mua.IsVisible = true;
                btn_ban.IsVisible = false;
                btn_ban1.IsVisible = false;
                btn_mua1.IsVisible = false;
                btn_mua2.IsVisible = false;

                entry_KL.Text = "";
                lbl_gia.Text = "";
                btn_mua.Text = "Xác nhận mua";
            }
        }

        private void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            if (lbl_mua.IsVisible == true)
            {
                lbl_mua.IsVisible = false;
                lbl_ban.IsVisible = true;
                text1.IsVisible = false;
                text2.IsVisible = true;
                btn_mua.IsVisible = true;
                btn_ban.IsVisible = false;
                btn_ban1.IsVisible = false;
                btn_mua1.IsVisible = false;
                btn_mua2.IsVisible = false;

                entry_KL.Text = "";
                lbl_gia.Text = "";
                btn_mua.Text = "Xác nhận bán";
            }
            else
            {
                lbl_mua.IsVisible = true;
                lbl_ban.IsVisible = false;
                text1.IsVisible = true;
                text2.IsVisible = false;
                btn_mua.IsVisible = true;
                btn_ban.IsVisible = false;
                btn_ban1.IsVisible = false;
                btn_mua1.IsVisible = false;
                btn_mua2.IsVisible = false;

                entry_KL.Text = "";
                lbl_gia.Text = "";
                btn_mua.Text = "Xác nhận mua";
            }
        }

        private void TapGestureRecognizer_Tapped_4(object sender, EventArgs e)
        {
            if (lbl_mua.IsVisible == true)
            {
                lbl_mua.IsVisible = false;
                lbl_ban.IsVisible = true;
                text1.IsVisible = false;
                text2.IsVisible = true;
                btn_mua.IsVisible = true;
                btn_ban.IsVisible = false;
                btn_ban1.IsVisible = false;
                btn_mua1.IsVisible = false;
                btn_mua2.IsVisible = false;
                entry_KL.Text = "";
                lbl_gia.Text = "";
                btn_mua.Text = "Xác nhận bán";
            }
            else
            {
                lbl_mua.IsVisible = true;
                lbl_ban.IsVisible = false;
                text1.IsVisible = true;
                text2.IsVisible = false;
                btn_mua.IsVisible = true;
                btn_ban.IsVisible = false;
                btn_ban1.IsVisible = false;
                btn_mua1.IsVisible = false;
                btn_mua2.IsVisible = false;
                entry_KL.Text = "";
                lbl_gia.Text = "";
                btn_mua.Text = "Xác nhận mua";
            }
        }

        private void TapGestureRecognizer_Tapped_5(object sender, EventArgs e)
        {
            if (lbl_thuong.IsVisible == true)
            {
                lbl_thuong.IsVisible = false;
                lbl_nhanh.IsVisible = true;

            }
            else
            {
                lbl_thuong.IsVisible = true;
                lbl_nhanh.IsVisible = false;

            }
        }

        private void TapGestureRecognizer_Tapped_6(object sender, EventArgs e)
        {
            if (lbl_thuong.IsVisible == true)
            {
                lbl_thuong.IsVisible = false;
                lbl_nhanh.IsVisible = true;

            }
            else
            {
                lbl_thuong.IsVisible = true;
                lbl_nhanh.IsVisible = false;

            }
        }

        private void TapGestureRecognizer_Tapped_7(object sender, EventArgs e)
        {
            if (lbl_thuong.IsVisible == true)
            {
                lbl_thuong.IsVisible = false;
                lbl_nhanh.IsVisible = true;

            }
            else
            {
                lbl_thuong.IsVisible = true;
                lbl_nhanh.IsVisible = false;

            }
        }

        private void TapGestureRecognizer_Tapped_8(object sender, EventArgs e)
        {
            if (lbl_thuong.IsVisible == true)
            {
                lbl_thuong.IsVisible = false;
                lbl_nhanh.IsVisible = true;

            }
            else
            {
                lbl_thuong.IsVisible = true;
                lbl_nhanh.IsVisible = false;

            }
        }

        private void TapGestureRecognizer_truKL(object sender, EventArgs e)
        {

            if (a != 0)
            {
                a = a - 1;
                entry_KL.Text = a.ToString();
            }
            if (entry_KL.Text == "500")
            {
                a = b - 1;
                entry_KL.Text = a.ToString();
            }
        }

        private void TapGestureRecognizer_CongKL(object sender, EventArgs e)
        {
            if (entry_KL.Text != "500")
            {
                a = a + 1;
                entry_KL.Text = a.ToString();
            }
        }

        private void TapGestureRecognizer_Tapped_max500(object sender, EventArgs e)
        {
            entry_KL.Text = "500";
           // Device.StartTimer(new TimeSpan(0, 60));
        }

        private void ATC_tap(object sender, EventArgs e)
        {

            lbl_gia.Text = "ATC";
            if (entry_KL.Text != "" && lbl_gia.Text != "" && lbl_mua.IsVisible == true)
            {
                btn_mua.IsVisible = false;
                btn_ban.IsVisible = true;


            }
            if (entry_KL.Text != "" && lbl_gia.Text != "" && lbl_mua.IsVisible == false)
            {
                btn_mua.IsVisible = false;
                btn_mua1.IsVisible = true;

            }

        }

        private void MP_tap(object sender, EventArgs e)
        {
            lbl_gia.Text = "MP";
        }

        private void ATO_tap(object sender, EventArgs e)
        {
            lbl_gia.Text = "ATO";
        }

        private void LO_tap(object sender, EventArgs e)
        {
            lbl_gia.Text = "";
        }

        private void matkhau_Unfocused(object sender, FocusEventArgs e)
        {
            if (entry_KL.Text != "" && lbl_gia.Text != "" && lbl_mua.IsVisible == false && matkhau.Text == "091298")
            {
                btn_mua.IsVisible = false;
                btn_mua2.IsVisible = true;
            }
            if (entry_KL.Text != "" && lbl_gia.Text != "" && lbl_mua.IsVisible == true && matkhau.Text == "091298")
            {
                btn_mua.IsVisible = false;
                btn_ban1.IsVisible = true;
            }
            if (entry_KL.Text == "" || lbl_gia.Text == "" && lbl_mua.IsVisible == true)
            {
                btn_mua.IsVisible = true;
                btn_mua.Text = "Xác nhận bán";
            }
            if (entry_KL.Text == "" || lbl_gia.Text == "" && lbl_mua.IsVisible == false)
            {
                btn_mua.IsVisible = true;
                btn_mua.Text = "Xác nhận mua";
            }
        }
        private void Button_sodu(object sender, EventArgs e)
        {
            boxview3.IsVisible = true;
            box_xuly.IsVisible = true;
        }

        private void TapGestureRecognizer_Tapped_9(object sender, EventArgs e)
        {
            boxview3.IsVisible = false;
            box_xuly.IsVisible = false;
        }

        private void box_xuly_Unfocused(object sender, FocusEventArgs e)
        {
            boxview3.IsVisible = false;
            box_xuly.IsVisible = false;
        }
    }
}