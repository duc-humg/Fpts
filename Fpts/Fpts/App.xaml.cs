using Fpts.Models;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fpts
{
    public partial class App : Application
    {
        public static ObservableCollection<Banggia> HSX { get; set; }
        public static ObservableCollection<Banggia> HNX { get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new MasterDetailMainview();
            HNX = new ObservableCollection<Banggia>();
            HSX = new ObservableCollection<Banggia>();
            HNX.Add(new Banggia { Ma = "VNI", thaydoi = "1164.21", sogd = 28.53, thaydoi1 = "2.60%", monney = "15758.59 tỷ", ma = "TS3", gia = "35", phantram = -0.5, khoiluong = "56,300", check1 = true, check2 = false, check3 = true, check4 = false, img = "sao.png" });
            HNX.Add(new Banggia { Ma = "VN100", thaydoi = "1107.82", sogd = 30.53, thaydoi1 = "2.60%", monney = "15758.59 tỷ", ma = "PTV", gia = "30", phantram = 0, khoiluong = "56,300", check1 = true, check2 = false, check3 = true, check4 = false, img = "sao.png" });
            HNX.Add(new Banggia { Ma = "VN30", thaydoi = "1151.3", sogd = 35.53, thaydoi1 = "2.60%", monney = "15758.59 tỷ", ma = "PVI", gia = "31", phantram = -0.6, khoiluong = "56,300", check1 = true, check2 = false, check3 = true, check4 = false, img = "sao.png" });
            HNX.Add(new Banggia { Ma = "VNALL", thaydoi = "1109.72", sogd = 32.53, thaydoi1 = "2.60%", monney = "15758.59 tỷ", ma = "SHB", gia = "32", phantram = -0.3, khoiluong = "56,300", check1 = true, check2 = false, check3 = true, check4 = false, img = "sao.png" });
            HNX.Add(new Banggia { Ma = "VNMID", thaydoi = "1382.57", sogd = 49.53, thaydoi1 = "2.60%", monney = "15758.59 tỷ", ma = "HAD", gia = "36", phantram = -0.2, khoiluong = "56,300", check1 = true, check2 = false, check3 = true, check4 = false, img = "sao.png" });
            HNX.Add(new Banggia { Ma = "VNSML", thaydoi = "1168.07", sogd = 35.53, thaydoi1 = "2.60%", monney = "15758.59 tỷ", ma = "ABC", gia = "48", phantram = 0, khoiluong = "56,300", check1 = true, check2 = false, check3 = true, check4 = false, img = "sao.png" });
            HNX.Add(new Banggia { Ma = "VNXALL", thaydoi = "1176.21", sogd = 48.53, thaydoi1 = "2.60%", monney = "15758.59 tỷ", ma = "HGA", gia = "63", phantram = 1, khoiluong = "56,300", check1 = true, check2 = false, check3 = true, check4 = false, img = "sao.png" });
            HSX.Add(new Banggia { Ma = "HNX30", thaydoi = "1176.21", sogd = 48.53, thaydoi1 = "2.60%", monney = "15758.59 tỷ", ma = "PNT", gia = "21", phantram = 1.2, khoiluong = "56,300", check1 = true, check2 = false, check3 = true, check4 = false, img = "sao.png" });
            HSX.Add(new Banggia { Ma = "HNXCON", thaydoi = "1176.21", sogd = 48.53, thaydoi1 = "2.60%", monney = "15758.59 tỷ", ma = "VIC", gia = "34", phantram = 1.3, khoiluong = "56,300", check1 = true, check2 = false, check3 = true, check4 = false, img = "sao.png" });
            HSX.Add(new Banggia { Ma = "HNXFIN", thaydoi = "1176.21", sogd = 48.53, thaydoi1 = "2.60%", monney = "15758.59 tỷ", ma = "MBB", gia = "30", phantram = 1.6, khoiluong = "56,300", check1 = true, check2 = false, check3 = true, check4 = false, img = "sao.png" });
            HSX.Add(new Banggia { Ma = "HNX", thaydoi = "1176.21", sogd = 38.53, thaydoi1 = "2.60%", monney = "15758.59 tỷ", ma = "MBB", gia = "30", phantram = 1.6, khoiluong = "56,300", check1 = true, check2 = false, check3 = true, check4 = false, img = "sao.png" });
            HSX.Add(new Banggia { Ma = "HNXLCAP", thaydoi = "1176.21", sogd = 38.53, thaydoi1 = "2.60%", monney = "15758.59 tỷ", ma = "MBB", gia = "30", phantram = 1.6, khoiluong = "56,300", check1 = true, check2 = false, check3 = true, check4 = false, img = "sao.png" });
            HSX.Add(new Banggia { Ma = "HNXMAN", thaydoi = "1176.21", sogd = 38.53, thaydoi1 = "2.60%", monney = "15758.59 tỷ", ma = "MBB", gia = "30", phantram = 1.6, khoiluong = "56,300", check1 = true, check2 = false, check3 = true, check4 = false, img = "sao.png" });
            HSX.Add(new Banggia { Ma = "HNXMSCA", thaydoi = "1176.21", sogd = 38.53, thaydoi1 = "2.60%", monney = "15758.59 tỷ", ma = "MBB", gia = "30", phantram = 1.6, khoiluong = "56,300", check1 = true, check2 = false, check3 = true, check4 = false, img = "sao.png" });
            HSX.Add(new Banggia { Ma = "UPCOM", thaydoi = "1176.21", sogd = 38.53, thaydoi1 = "2.60%", monney = "15758.59 tỷ", ma = "MBB", gia = "30", phantram = 1.6, khoiluong = "56,300", check1 = true, check2 = false, check3 = true, check4 = false, img = "sao.png" });

            foreach (var item in HNX)
            {
                if (item.sogd > 40.00)
                {
                    item.color = "#6ac164";
                }
                if (item.sogd == 48.53)
                {
                    item.color = "#f26f21";
                }
                if (item.sogd < 40.00)
                {
                    item.color = "#c3161c";
                }

            }
            foreach (var iteam in HNX)
            {
                if (iteam.phantram > 0)
                {
                    iteam.mau = "#6ac164";
                }
                if (iteam.phantram == 0)
                {
                    iteam.mau = "#f26f21";
                }
                if (iteam.phantram < 0)
                {
                    iteam.mau = "#c3161c";
                }
            }
            foreach (var item in HSX)
            {
                if (item.sogd > 40.00)
                {
                    item.color = "#6ac164";
                }
                if (item.sogd == 48.53)
                {
                    item.color = "#f26f21";
                }
                if (item.sogd < 40.00)
                {
                    item.color = "#c3161c";
                }

            }
            foreach (var iteam in HSX)
            {
                if (iteam.phantram > 0)
                {
                    iteam.mau = "#6ac164";
                }
                if (iteam.phantram == 0)
                {
                    iteam.mau = "#f26f21";
                }
                if (iteam.phantram < 0)
                {
                    iteam.mau = "#c3161c";
                }
            }
            foreach (var icon in HNX)
            {
                if (icon.check5 == false)
                {
                    icon.img = "sao.png";
                }
                else
                    icon.img = "saovang.png";
            }
            foreach (var icon in HSX)
            {
                if (icon.check5 == false)
                {
                    icon.img = "sao.png";
                }
                else
                    icon.img = "saovang.png";
            }
            

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
