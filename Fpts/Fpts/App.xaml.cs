using Fpts.Models;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fpts
{
    public partial class App : Application
    {
        public static ObservableCollection<CoPhieuModel> ListHSX { get; set; }
        public static ObservableCollection<CoPhieuModel> ListHNX { get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new MasterDetailMainview();
            ListHNX = new ObservableCollection<CoPhieuModel>();
            ListHSX = new ObservableCollection<CoPhieuModel>();
            ListHNX.Add(new CoPhieuModel { MaChiSo = "VNI", GiaChiSo = "1164.21", ThayDoiOne = 28.53, ThayDoiTow = "2.60%", GiaTri = "15758.59 tỷ", MaChungkhoan = "TS3", GiaChungKhoan = "35", TangGiamOne = -0.5, KhoiLuong = "56,300", TangGiamTow = 2.5, CheckThayDoiTow = true, CheckThayDoiOne = false ,CheckShowKhoiLuong = true, CheckShowGia = false, imgSao = "sao.png" });
            ListHNX.Add(new CoPhieuModel { MaChiSo = "VN100", GiaChiSo = "1107.82", ThayDoiOne = 30.53, ThayDoiTow = "2.60%", GiaTri = "15758.59 tỷ", MaChungkhoan = "PTV", GiaChungKhoan = "30", TangGiamOne = 0, KhoiLuong = "56,300", TangGiamTow = 1.5, CheckThayDoiTow = true, CheckThayDoiOne = false, CheckShowKhoiLuong = true, CheckShowGia = false, imgSao = "sao.png" });
            ListHNX.Add(new CoPhieuModel { MaChiSo = "VN30", GiaChiSo = "1151.3", ThayDoiOne = 35.53, ThayDoiTow = "2.60%", GiaTri = "15758.59 tỷ", MaChungkhoan = "PVI", GiaChungKhoan = "31", TangGiamOne = -0.6, KhoiLuong = "56,300", TangGiamTow = 0.0, CheckThayDoiTow = true, CheckThayDoiOne = false, CheckShowKhoiLuong = true, CheckShowGia = false, imgSao = "sao.png" });
            ListHNX.Add(new CoPhieuModel { MaChiSo = "VNALL", GiaChiSo = "1109.72", ThayDoiOne = 32.53, ThayDoiTow = "2.60%", GiaTri = "15758.59 tỷ", MaChungkhoan = "SHB", GiaChungKhoan = "32", TangGiamOne = -0.3, KhoiLuong = "56,300", TangGiamTow = 1.1, CheckThayDoiTow = true, CheckThayDoiOne = false, CheckShowKhoiLuong = true, CheckShowGia = false, imgSao = "sao.png" });
            ListHNX.Add(new CoPhieuModel { MaChiSo = "VNMID", GiaChiSo = "1382.57", ThayDoiOne = 49.53, ThayDoiTow = "2.60%", GiaTri = "15758.59 tỷ", MaChungkhoan = "HAD", GiaChungKhoan = "36", TangGiamOne = -0.2, KhoiLuong = "56,300", TangGiamTow = 2.6, CheckThayDoiTow = true, CheckThayDoiOne = false, CheckShowKhoiLuong = true, CheckShowGia = false, imgSao = "sao.png" });
            ListHNX.Add(new CoPhieuModel { MaChiSo = "VNSML", GiaChiSo = "1168.07", ThayDoiOne = 35.53, ThayDoiTow = "2.60%", GiaTri = "15758.59 tỷ", MaChungkhoan = "ABC", GiaChungKhoan = "48", TangGiamOne = 0, KhoiLuong = "56,300", TangGiamTow = 12.5, CheckThayDoiTow = true, CheckThayDoiOne = false, CheckShowKhoiLuong = true, CheckShowGia = false, imgSao = "sao.png" });
            ListHNX.Add(new CoPhieuModel { MaChiSo = "VNXALL", GiaChiSo = "1176.21", ThayDoiOne = 48.53, ThayDoiTow = "2.60%", GiaTri = "15758.59 tỷ", MaChungkhoan = "HGA", GiaChungKhoan = "63", TangGiamOne = 1, KhoiLuong = "56,300", TangGiamTow = 3.6, CheckThayDoiTow = true, CheckThayDoiOne = false, CheckShowKhoiLuong = true, CheckShowGia = false, imgSao = "sao.png" });
            ListHSX.Add(new CoPhieuModel { MaChiSo = "HNX30", GiaChiSo = "1176.21", ThayDoiOne = 48.53, ThayDoiTow = "2.60%", GiaTri = "15758.59 tỷ", MaChungkhoan = "PNT", GiaChungKhoan = "21", TangGiamOne = 1.2, KhoiLuong = "56,300", TangGiamTow = 4.2, CheckThayDoiTow = true, CheckThayDoiOne = false, CheckShowKhoiLuong = true, CheckShowGia = false, imgSao = "sao.png" });
            ListHSX.Add(new CoPhieuModel { MaChiSo = "HNXCON", GiaChiSo = "1176.21", ThayDoiOne = 48.53, ThayDoiTow = "2.60%", GiaTri = "15758.59 tỷ", MaChungkhoan = "VIC", GiaChungKhoan = "34", TangGiamOne = 1.3, KhoiLuong = "56,300", TangGiamTow = 5.0, CheckThayDoiTow = true, CheckThayDoiOne = false, CheckShowKhoiLuong = true, CheckShowGia = false, imgSao = "sao.png" });
            ListHSX.Add(new CoPhieuModel { MaChiSo = "HNXFIN", GiaChiSo = "1176.21", ThayDoiOne = 48.53, ThayDoiTow = "2.60%", GiaTri = "15758.59 tỷ", MaChungkhoan = "MBB", GiaChungKhoan = "30", TangGiamOne = 1.6, KhoiLuong = "56,300", TangGiamTow = 2.0, CheckThayDoiTow = true, CheckThayDoiOne = false, CheckShowKhoiLuong = true, CheckShowGia = false, imgSao = "sao.png" });
            ListHSX.Add(new CoPhieuModel { MaChiSo = "HNX", GiaChiSo = "1176.21", ThayDoiOne = 38.53, ThayDoiTow = "2.60%", GiaTri = "15758.59 tỷ", MaChungkhoan = "MBB", GiaChungKhoan = "30", TangGiamOne = 1.6, KhoiLuong = "56,300", TangGiamTow = 6.0, CheckThayDoiTow = true, CheckThayDoiOne = false, CheckShowKhoiLuong = true, CheckShowGia = false, imgSao = "sao.png" });
            ListHSX.Add(new CoPhieuModel { MaChiSo = "HNXLCAP", GiaChiSo = "1176.21", ThayDoiOne = 38.53, ThayDoiTow = "2.60%", GiaTri = "15758.59 tỷ", MaChungkhoan = "MBB", GiaChungKhoan = "30", TangGiamOne = 1.6, KhoiLuong = "56,300", TangGiamTow = 12.1, CheckThayDoiTow = true, CheckThayDoiOne = false, CheckShowKhoiLuong = true, CheckShowGia = false, imgSao = "sao.png" });
            ListHSX.Add(new CoPhieuModel { MaChiSo = "HNXMAN", GiaChiSo = "1176.21", ThayDoiOne = 38.53, ThayDoiTow = "2.60%", GiaTri = "15758.59 tỷ", MaChungkhoan = "MBB", GiaChungKhoan = "30", TangGiamOne = 1.6, KhoiLuong = "56,300", TangGiamTow = 2.3, CheckThayDoiTow = true, CheckThayDoiOne = false, CheckShowKhoiLuong = true, CheckShowGia = false, imgSao = "sao.png" });
            ListHSX.Add(new CoPhieuModel { MaChiSo = "HNXMSCAP", GiaChiSo = "1176.21", ThayDoiOne = 38.53, ThayDoiTow = "2.60%", GiaTri = "15758.59 tỷ", MaChungkhoan = "MBB", GiaChungKhoan = "30", TangGiamOne = 1.6, KhoiLuong = "56,300", TangGiamTow = 5.7, CheckThayDoiTow = true, CheckThayDoiOne = false, CheckShowKhoiLuong = true, CheckShowGia = false, imgSao = "sao.png" });
            ListHSX.Add(new CoPhieuModel { MaChiSo = "UPCOM", GiaChiSo = "1176.21", ThayDoiOne = 38.53, ThayDoiTow = "2.60%", GiaTri = "15758.59 tỷ", MaChungkhoan = "MBB", GiaChungKhoan = "30", TangGiamOne = 1.6, KhoiLuong = "56,300", TangGiamTow = 22.5, CheckThayDoiTow = true, CheckThayDoiOne = false, CheckShowKhoiLuong = true, CheckShowGia = false, imgSao = "sao.png" });

            foreach (var item in ListHNX)
            {
                if (item.ThayDoiOne > 40.00)
                {
                    item.ColorNumber = "#6ac164";
                }
                if (item.ThayDoiOne == 48.53)
                {
                    item.ColorNumber = "#f26f21";
                }
                if (item.ThayDoiOne < 40.00)
                {
                    item.ColorNumber = "#c3161c";
                }

            }
            foreach (var iteam in ListHNX)
            {
                if (iteam.TangGiamOne > 0)
                {
                    iteam.ColorMa = "#6ac164";
                }
                if (iteam.TangGiamOne == 0)
                {
                    iteam.ColorMa = "#f26f21";
                }
                if (iteam.TangGiamOne < 0)
                {
                    iteam.ColorMa = "#c3161c";
                }
            }
            foreach (var item in ListHSX)
            {
                if (item.ThayDoiOne > 40.00)
                {
                    item.ColorNumber = "#6ac164";
                }
                if (item.ThayDoiOne == 48.53)
                {
                    item.ColorNumber = "#f26f21";
                }
                if (item.ThayDoiOne < 40.00)
                {
                    item.ColorNumber = "#c3161c";
                }

            }
            foreach (var iteam in ListHSX)
            {
                if (iteam.TangGiamOne > 0)
                {
                    iteam.ColorMa = "#6ac164";
                }
                if (iteam.TangGiamOne == 0)
                {
                    iteam.ColorMa = "#f26f21";
                }
                if (iteam.TangGiamOne < 0)
                {
                    iteam.ColorMa = "#c3161c";
                }
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
