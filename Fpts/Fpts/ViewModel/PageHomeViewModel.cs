using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using Fpts.Models;
using Xamarin.Forms;
using Fpts.Views;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Fpts.ViewModel
{
    public class PageHomeViewModel
    {
        protected void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
        public ObservableCollection<CoPhieuModel> ListMaChungKhoan { get; set; }
        public ObservableCollection<DanhMucModel> ListTaoDanhMuc { get; set; }
        public Command<object> DeleteCommand { get; set; }
        public Command<object> DeleteDanhmucCommand { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        public PageHomeViewModel()
        {
            //
            ListTaoDanhMuc = new ObservableCollection<DanhMucModel>();
            ListTaoDanhMuc.Add(new DanhMucModel { NameDanhMuc = "bcd",Image= "kiemtra.png" });
            ListMaChungKhoan = new ObservableCollection<CoPhieuModel>();
            DeleteCommand = new Command<object>(Delete);
            DeleteDanhmucCommand = new Command<object>(DeleteDanhmuc);
            ListMaChungKhoan.Add(new CoPhieuModel { MaChiSo = "VNI", GiaChiSo = "1164.21", ThayDoiOne = 28.53, ThayDoiTow = "2.60%", GiaTri = "15758.59 tỷ", MaChungkhoan = "TS3", GiaChungKhoan = "35", TangGiamOne = -0.5, KhoiLuong = "56,300", TangGiamTow = 2.5, CheckTangGiamTow = true, CheckTangGiamOne = false });
            ListMaChungKhoan.Add(new CoPhieuModel { MaChiSo = "VN100", GiaChiSo = "1107.82", ThayDoiOne = 30.53, ThayDoiTow = "2.60%", GiaTri = "15758.59 tỷ", MaChungkhoan = "PTV", GiaChungKhoan = "30", TangGiamOne = 0, KhoiLuong = "56,300", TangGiamTow = 1.5, CheckTangGiamTow = true, CheckTangGiamOne = false });
            ListMaChungKhoan.Add(new CoPhieuModel { MaChiSo = "VN30", GiaChiSo = "1151.3", ThayDoiOne = 35.53, ThayDoiTow = "2.60%", GiaTri = "15758.59 tỷ", MaChungkhoan = "PVI", GiaChungKhoan = "31", TangGiamOne = -0.6, KhoiLuong = "56,300", TangGiamTow = 0.0, CheckTangGiamTow = true, CheckTangGiamOne = false });
            ListMaChungKhoan.Add(new CoPhieuModel { MaChiSo = "VNALL", GiaChiSo = "1109.72", ThayDoiOne = 32.53, ThayDoiTow = "2.60%", GiaTri = "15758.59 tỷ", MaChungkhoan = "SHB", GiaChungKhoan = "32", TangGiamOne = -0.3, KhoiLuong = "56,300", TangGiamTow = 1.1, CheckTangGiamTow = true, CheckTangGiamOne = false });
            ListMaChungKhoan.Add(new CoPhieuModel { MaChiSo = "VNMID", GiaChiSo = "1382.57", ThayDoiOne = 49.53, ThayDoiTow = "2.60%", GiaTri = "15758.59 tỷ", MaChungkhoan = "HAD", GiaChungKhoan = "36", TangGiamOne = -0.2, KhoiLuong = "56,300", TangGiamTow = 2.6, CheckTangGiamTow = true, CheckTangGiamOne = false });
            ListMaChungKhoan.Add(new CoPhieuModel { MaChiSo = "VNSML", GiaChiSo = "1168.07", ThayDoiOne = 35.53, ThayDoiTow = "2.60%", GiaTri = "15758.59 tỷ", MaChungkhoan = "ABC", GiaChungKhoan = "48", TangGiamOne = 0, KhoiLuong = "56,300", TangGiamTow = 12.5, CheckTangGiamTow = true, CheckTangGiamOne = false });
            ListMaChungKhoan.Add(new CoPhieuModel { MaChiSo = "VNXALL", GiaChiSo = "1176.21", ThayDoiOne = 48.53, ThayDoiTow = "2.60%", GiaTri = "15758.59 tỷ", MaChungkhoan = "HGA", GiaChungKhoan = "63", TangGiamOne = 1, KhoiLuong = "56,300", TangGiamTow = 3.6, CheckTangGiamTow = true, CheckTangGiamOne = false });
            ListMaChungKhoan.Add(new CoPhieuModel { MaChiSo = "HNX30", GiaChiSo = "1176.21", ThayDoiOne = 48.53, ThayDoiTow = "2.60%", GiaTri = "15758.59 tỷ", MaChungkhoan = "PNT", GiaChungKhoan = "21", TangGiamOne = 1.2, KhoiLuong = "56,300", TangGiamTow = 4.2, CheckTangGiamTow = true, CheckTangGiamOne = false });
            ListMaChungKhoan.Add(new CoPhieuModel { MaChiSo = "HNXCON", GiaChiSo = "1176.21", ThayDoiOne = 48.53, ThayDoiTow = "2.60%", GiaTri = "15758.59 tỷ", MaChungkhoan = "VIC", GiaChungKhoan = "34", TangGiamOne = 1.3, KhoiLuong = "56,300", TangGiamTow = 5.0, CheckTangGiamTow = true, CheckTangGiamOne = false });
            ListMaChungKhoan.Add(new CoPhieuModel { MaChiSo = "HNXFIN", GiaChiSo = "1176.21", ThayDoiOne = 48.53, ThayDoiTow = "2.60%", GiaTri = "15758.59 tỷ", MaChungkhoan = "MBB", GiaChungKhoan = "30", TangGiamOne = 1.6, KhoiLuong = "56,300", TangGiamTow = 2.0, CheckTangGiamTow = true, CheckTangGiamOne = false });
            ListMaChungKhoan.Add(new CoPhieuModel { MaChiSo = "HNX", GiaChiSo = "1176.21", ThayDoiOne = 38.53, ThayDoiTow = "2.60%", GiaTri = "15758.59 tỷ", MaChungkhoan = "MBB", GiaChungKhoan = "30", TangGiamOne = 1.6, KhoiLuong = "56,300", TangGiamTow = 6.0, CheckTangGiamTow = true, CheckTangGiamOne = false });
            ListMaChungKhoan.Add(new CoPhieuModel { MaChiSo = "HNXLCAP", GiaChiSo = "1176.21", ThayDoiOne = 38.53, ThayDoiTow = "2.60%", GiaTri = "15758.59 tỷ", MaChungkhoan = "MBB", GiaChungKhoan = "30", TangGiamOne = 1.6, KhoiLuong = "56,300", TangGiamTow = 12.1, CheckTangGiamTow = true, CheckTangGiamOne = false });
            ListMaChungKhoan.Add(new CoPhieuModel { MaChiSo = "HNXMAN", GiaChiSo = "1176.21", ThayDoiOne = 38.53, ThayDoiTow = "2.60%", GiaTri = "15758.59 tỷ", MaChungkhoan = "MBB", GiaChungKhoan = "30", TangGiamOne = 1.6, KhoiLuong = "56,300", TangGiamTow = 2.3, CheckTangGiamTow = true, CheckTangGiamOne = false });
            ListMaChungKhoan.Add(new CoPhieuModel { MaChiSo = "HNXMSCAP", GiaChiSo = "1176.21", ThayDoiOne = 38.53, ThayDoiTow = "2.60%", GiaTri = "15758.59 tỷ", MaChungkhoan = "MBB", GiaChungKhoan = "30", TangGiamOne = 1.6, KhoiLuong = "56,300", TangGiamTow = 5.7, CheckTangGiamTow = true, CheckTangGiamOne = false });
            ListMaChungKhoan.Add(new CoPhieuModel { MaChiSo = "UPCOM", GiaChiSo = "1176.21", ThayDoiOne = 38.53, ThayDoiTow = "2.60%", GiaTri = "15758.59 tỷ", MaChungkhoan = "MBB", GiaChungKhoan = "30", TangGiamOne = 1.6, KhoiLuong = "56,300", TangGiamTow = 22.5, CheckTangGiamTow = true, CheckTangGiamOne = false });
            foreach (var item in ListMaChungKhoan)
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
            foreach (var iteam in ListMaChungKhoan)
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

        /// <summary>
        /// xóa ListMachungkhoan
        /// </summary>
        private void DeleteDanhmuc(object obj)
        {
            var ik = obj as DanhMucModel;
            ListTaoDanhMuc.Remove(ik);
        }

        /// <summary>
        /// xóa ListDanhMuc
        /// </summary>
        async private void Delete(object obj)
        {
            var res = await App.Current.MainPage.DisplayAlert("Success", "Your data are saved", "Ok", "Cancel");
            var im = obj as CoPhieuModel;

            if (res)
            {
                ListMaChungKhoan.Remove(im);
            }
        }
        
    }
}
