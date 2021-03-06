﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using Fpts.Models;
using Xamarin.Forms;
using Fpts.Views;
using System.ComponentModel;
using System.Threading.Tasks;
using Fpts.Control;

namespace Fpts.ViewModel
{
    public class ViewXulyTuongTacViewModel : INotifyPropertyChanged
    {
        protected void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<MenuModel> ListTuongTac { get; set; }
        public ObservableCollection<MenuModel> ListThayThe { get; set; }
        public Command<object> CheckCommand { get; set; }
        public Command<object> TickCommand { get; set; }
        public string Selected1 { get; set; }

        public ViewXulyTuongTacViewModel()
        {

            CheckCommand = new Command<object>(check);
            TickCommand = new Command<object>(Click1);
            ListTuongTac = new ObservableCollection<MenuModel>();
            ListTuongTac.Add(new MenuModel { stt = 0, TextKeyTop = "Thị trường", Key = "top" });
            ListTuongTac.Add(new MenuModel { stt = 1, Image = "tongquan.png", Sao = "sao.png", TextKeyMid = "Tổng quan", Key = "mid", CheckSao = false });
            ListTuongTac.Add(new MenuModel { stt = 2, Image = "book.png", Sao = "sao.png", TextKeyMid = "Bảng Giá", Key = "mid", CheckSao = false });
            ListTuongTac.Add(new MenuModel { stt = 3, Image = "tintuc.png", Sao = "sao.png", TextKeyMid = "Tin tức", Key = "mid", CheckSao = false });
            ListTuongTac.Add(new MenuModel { stt = 4, Image = "chiso.png", Sao = "sao.png", TextKeyMid = "Chỉ số thế giới", Key = "mid", CheckSao = false });
            ListTuongTac.Add(new MenuModel { stt = 5, Image = "nhandinh.png", Sao = "sao.png", TextKeyMid = "FPTS nhận định", Key = "mid", CheckSao = false });
            ListTuongTac.Add(new MenuModel { stt = 6, Image = "lich.png", Sao = "sao.png", TextKeyMid = "Lịch sự kiện", Key = "mid", CheckSao = false });
            ListTuongTac.Add(new MenuModel { stt = 7, Image = "dothi.png", Sao = "sao.png", TextKeyMid = "Biểu đồ", Key = "mid", CheckSao = false });
            ListTuongTac.Add(new MenuModel { stt = 8, Image = "sort.png", Sao = "sao.png", TextKeyMid = "Giao dịch phát sinh", Key = "mid", CheckSao = false });
            ListTuongTac.Add(new MenuModel { stt = 9, TextKeyTop = "Giao dịch", Key = "top" });
            ListTuongTac.Add(new MenuModel { stt = 10, Image = "datlenh.png", Sao = "sao.png", TextKeyMid = "Đặt lệnh", Key = "mid", CheckSao = false });
            ListTuongTac.Add(new MenuModel { stt = 11, Image = "nhandinh.png", Sao = "sao.png", TextKeyBot = "Báo cáo Giao dịch", Key = "bot", CheckSao = false, CheckNutThemSuKien = true, CheckSuKienKeoDai = true, TextKeyBotOne = "Lệnh trong ngày", TextKeyBotTow = "Lịch sử đặt lệnh", TextKeyBotThree = "Lịch sử ứng trước" });
            ListTuongTac.Add(new MenuModel { stt = 12, Image = "taikhoan.png", Sao = "sao.png", TextKeyBot = "Quản lý tài khoản", Key = "bot", CheckSao = false, CheckNutThemSuKien = true, CheckSuKienKeoDai = true, TextKeyBotEight = "Sao kê chứng khoán", TextKeyBotFour = "Sao kê tiền", TextKeyBotFive = "Tra cứu phí lưu ký", TextKeyBotSix = "Tra cứu tình trạng chứng quyền", TextKeyBotSeven = "Tra cứu biểu phí" });
            ListTuongTac.Add(new MenuModel { stt = 13, Image = "baocao.png", Sao = "sao.png", TextKeyMid = "Báo cáo tài sản", Key = "mid", CheckSao = false });
            ListTuongTac.Add(new MenuModel { stt = 14, Image = "atm.png", Sao = "sao.png", TextKeyMid = "Bán lô lẻ", Key = "mid", CheckSao = false });
            ListTuongTac.Add(new MenuModel { stt = 15, Image = "quyen.png", Sao = "sao.png", TextKeyMid = "Thực hiện quyền", Key = "mid", CheckSao = false });
            ListTuongTac.Add(new MenuModel { stt = 16, TextKeyTop = "Trợ giúp", Key = "top" });
            ListTuongTac.Add(new MenuModel { stt = 17, Image = "thongbao.png", Sao = "sao.png", TextKeyMid = "Thông báo", Key = "mid", CheckSao = false });
            ListTuongTac.Add(new MenuModel { stt = 18, Image = "matkhau.png", Sao = "sao.png", TextKeyMid = "Cài đặt mật khẩu", Key = "mid", CheckSao = false });
            ListTuongTac.Add(new MenuModel { stt = 19, Image = "lienhe.png", Sao = "sao.png", TextKeyMid = "Liên hệ", Key = "mid", CheckSao = false });
            ListTuongTac.Add(new MenuModel { stt = 20, Image = "love.png", Sao = "sao.png", TextKeyMid = "Góp ý", Key = "mid", CheckSao = false });
            ListTuongTac.Add(new MenuModel { stt = 21, Image = "book.png", Sao = "sao.png", TextKeyMid = "Hướng dẫn sử dụng", Key = "mid", CheckSao = false });
            ListTuongTac.Add(new MenuModel { stt = 22, Image = "seting.png", Sao = "sao.png", TextKeyMid = "Cài đặt", Key = "mid", CheckSao = false });

            //list2 = new ObservableCollection<MenuModel>();
            //list2.Add(new MenuModel { TextKeyTop = "Thị trường", Key = "top" });
            //list2.Add(new MenuModel { Image = "tongquan.png", Sao = "Sao.png", TextKeyMid = "Tổng quan", Key = "mid", CheckSao = true });
            //list2.Add(new MenuModel { Image = "book.png", Sao = "Sao.png", TextKeyMid = "Bảng Giá", Key = "mid", CheckSao = true });
            //list2.Add(new MenuModel { Image = "tintuc.png", Sao = "Sao.png", TextKeyMid = "Tin tức", Key = "mid", CheckSao = true });
            //list2.Add(new MenuModel { Image = "chiso.png", Sao = "Sao.png", TextKeyMid = "Chỉ số thế giới", Key = "mid", CheckSao = true });
            //list2.Add(new MenuModel { Image = "nhandinh.png", Sao = "Sao.png", TextKeyMid = "FPTS nhận định", Key = "mid", CheckSao = true });
            //list2.Add(new MenuModel { Image = "lich.png", Sao = "Sao.png", TextKeyMid = "Lịch sự kiện", Key = "mid", CheckSao = true });
            //list2.Add(new MenuModel { Image = "dothi.png", Sao = "Sao.png", TextKeyMid = "Biểu đồ", Key = "mid", CheckSao = true });
            //list2.Add(new MenuModel { Image = "sort.png", Sao = "Sao.png", TextKeyMid = "Giao dịch phát sinh", Key = "mid", CheckSao = true });
            //list2.Add(new MenuModel { TextKeyTop = "Giao dịch", Key = "top" });
            //list2.Add(new MenuModel { Image = "datlenh.png", Sao = "Sao.png", TextKeyMid = "Đặt lệnh", Key = "mid", CheckSao = true });
            //list2.Add(new MenuModel { Image = "nhandinh.png", Sao = "Sao.png", TextKeyMid = "Báo cáo Giao dịch", Key = "bot", CheckSao = true, checkNutThemSuKien = true, CheckSuKienKeoDai = true, img1 = "up.png" });
            //list2.Add(new MenuModel { Image = "taikhoan.png", Sao = "Sao.png", TextKeyMid = "Quản lý tài khoản", Key = "bot", CheckSao = true, checkNutThemSuKien = true, CheckSuKienKeoDai = true, img1 = "up.png"});
            //list2.Add(new MenuModel { Image = "baocao.png", Sao = "Sao.png", TextKeyMid = "Báo cáo tài sản", Key = "mid", CheckSao = true });
            //list2.Add(new MenuModel { Image = "atm.png", Sao = "Sao.png", TextKeyMid = "Bán lô lẻ", Key = "mid", CheckSao = true });
            //list2.Add(new MenuModel { Image = "quyen.png", Sao = "Sao.png", TextKeyMid = "Thực hiện quyền", Key = "mid", CheckSao = true });
            //list2.Add(new MenuModel { TextKeyTop = "Trợ giúp", Key = "top" });
            //list2.Add(new MenuModel { Image = "thongbao.png", Sao = "Sao.png", TextKeyMid = "Thông báo", Key = "mid", CheckSao = true });
            //list2.Add(new MenuModel { Image = "matkhau.png", Sao = "Sao.png", TextKeyMid = "Cài đặt mật khẩu", Key = "mid", CheckSao = true });
            //list2.Add(new MenuModel { Image = "lienhe.png", Sao = "Sao.png", TextKeyMid = "Liên hệ", Key = "mid", CheckSao = true });
            //list2.Add(new MenuModel { Image = "love.png", Sao = "Sao.png", TextKeyMid = "Góp ý", Key = "mid", CheckSao = true });
            //list2.Add(new MenuModel { Image = "book.png", Sao = "Sao.png", TextKeyMid = "Hướng dẫn sử dụng", Key = "mid", CheckSao = true });
            //list2.Add(new MenuModel { Image = "seting.png", Sao = "Sao.png", TextKeyMid = "Cài đặt", Key = "mid", CheckSao = true });
            ListThayThe = new ObservableCollection<MenuModel>();
            ListThayThe.Add(new MenuModel { TextKeyTop = "Yêu Thích", Key = "top" });
            ListThayThe.Add(new MenuModel { TextKeyTop = "Thị trường", Key = "top" });
            ListThayThe.Add(new MenuModel { Image = "tongquan.png", Sao = "Sao.png", TextKeyMid = "Tổng quan", Key = "mid", CheckSao = false });
            ListThayThe.Add(new MenuModel { Image = "book.png", Sao = "Sao.png", TextKeyMid = "Bảng Giá", Key = "mid", CheckSao = false });
            ListThayThe.Add(new MenuModel { Image = "tintuc.png", Sao = "Sao.png", TextKeyMid = "Tin tức", Key = "mid", CheckSao = false });
            ListThayThe.Add(new MenuModel { Image = "chiso.png", Sao = "Sao.png", TextKeyMid = "Chỉ số thế giới", Key = "mid", CheckSao = false });
            ListThayThe.Add(new MenuModel { Image = "nhandinh.png", Sao = "Sao.png", TextKeyMid = "FPTS nhận định", Key = "mid", CheckSao = false });
            ListThayThe.Add(new MenuModel { Image = "lich.png", Sao = "Sao.png", TextKeyMid = "Lịch sự kiện", Key = "mid", CheckSao = false });
            ListThayThe.Add(new MenuModel { Image = "dothi.png", Sao = "Sao.png", TextKeyMid = "Biểu đồ", Key = "mid", CheckSao = false });
            ListThayThe.Add(new MenuModel { Image = "sort.png", Sao = "Sao.png", TextKeyMid = "Giao dịch phát sinh", Key = "mid", CheckSao = false });
            ListThayThe.Add(new MenuModel { TextKeyTop = "Giao dịch", Key = "top" });
            ListThayThe.Add(new MenuModel { Image = "datlenh.png", Sao = "Sao.png", TextKeyMid = "Đặt lệnh", Key = "mid", CheckSao = false });
            ListThayThe.Add(new MenuModel { Image = "nhandinh.png", Sao = "Sao.png", TextKeyBot = "Báo cáo Giao dịch", Key = "bot", CheckSao = false, CheckNutThemSuKien = true, CheckSuKienKeoDai = true, TextKeyBotOne = "Lệnh trong ngày", TextKeyBotTow = "Lịch sử đặt lệnh", TextKeyBotThree = "Lịch sử ứng trước" });
            ListThayThe.Add(new MenuModel { Image = "taikhoan.png", Sao = "Sao.png", TextKeyBot = "Quản lý tài khoản", Key = "bot", CheckSao = false, CheckNutThemSuKien = true, CheckSuKienKeoDai = true, TextKeyBotEight = "Sao kê chứng khoán", TextKeyBotFour = "Sao kê tiền", TextKeyBotFive = "Tra cứu phí lưu ký", TextKeyBotSix = "Tra cứu tình trạng chứng quyền", TextKeyBotSeven = "Tra cứu biểu phí" });
            ListThayThe.Add(new MenuModel { Image = "baocao.png", Sao = "Sao.png", TextKeyMid = "Báo cáo tài sản", Key = "mid", CheckSao = false });
            ListThayThe.Add(new MenuModel { Image = "atm.png", Sao = "Sao.png", TextKeyMid = "Bán lô lẻ", Key = "mid", CheckSao = false });
            ListThayThe.Add(new MenuModel { Image = "quyen.png", Sao = "Sao.png", TextKeyMid = "Thực hiện quyền", Key = "mid", CheckSao = false });
            ListThayThe.Add(new MenuModel { TextKeyTop = "Trợ giúp", Key = "top" });
            ListThayThe.Add(new MenuModel { Image = "thongbao.png", Sao = "Sao.png", TextKeyMid = "Thông báo", Key = "mid", CheckSao = false });
            ListThayThe.Add(new MenuModel { Image = "matkhau.png", Sao = "Sao.png", TextKeyMid = "Cài đặt mật khẩu", Key = "mid", CheckSao = false });
            ListThayThe.Add(new MenuModel { Image = "lienhe.png", Sao = "Sao.png", TextKeyMid = "Liên hệ", Key = "mid", CheckSao = false });
            ListThayThe.Add(new MenuModel { Image = "love.png", Sao = "Sao.png", TextKeyMid = "Góp ý", Key = "mid", CheckSao = false });
            ListThayThe.Add(new MenuModel { Image = "book.png", Sao = "Sao.png", TextKeyMid = "Hướng dẫn sử dụng", Key = "mid", CheckSao = false });
            ListThayThe.Add(new MenuModel { Image = "seting.png", Sao = "Sao.png", TextKeyMid = "Cài đặt", Key = "mid", CheckSao = false });


        }

        private void check(object obj)
        {
            var mn = obj as MenuModel;
            if (mn.CheckSaoVang == false)
            {
                mn.CheckSaoVang = true;
                mn.Sao = "saovang.png";
                mn.CheckNutThemSuKien = false;
                mn.Key = "mid";
                mn.stt = 1;
                ListThayThe.Insert(1, mn);

            }
            else
            {
                mn.CheckSaoVang = false;
                mn.Sao = "sao.png";
                mn.CheckNutThemSuKien = true;
                ListThayThe.Remove(mn);
            }
        }

        private void Click1(object obj)
        {
            foreach (var itam in ListThayThe)
            {
                if (itam.Sao == "saovang.png")
                {
                    App.test1 = true;
                    break;
                }
                else
                {
                     App.test1 = false;
                }
            }
        }

    }
}

