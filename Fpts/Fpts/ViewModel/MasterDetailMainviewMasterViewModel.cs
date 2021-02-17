﻿using System;
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
    public class MasterDetailMainviewMasterViewModel : INotifyPropertyChanged
    {
        protected void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<menu> list1 { get; set; }
        public ObservableCollection<menu> list2 { get; set; }
        public ObservableCollection<menu> list3 { get; set; }
        public Command<object> CheckCommand { get; set; }
        public Command<object> TickCommand { get; set; }
        public string Selected1 { get; set; }

        public MasterDetailMainviewMasterViewModel()
        {
            CheckCommand = new Command<object>(Click);
            TickCommand = new Command<object>(Click1);
            list1 = new ObservableCollection<menu>();
            
            list1.Add(new menu { text = "Thị trường", key = "top" });
            list1.Add(new menu { image = "tongquan.png", sao = "sao.png", text1 = "Tổng quan" ,key="mid", check1=false});
            list1.Add(new menu { image = "book.png", sao = "sao.png", text1 = "Bảng Giá", key = "mid", check1 = false });
            list1.Add(new menu { image = "tintuc.png", sao = "sao.png", text1 = "Tin tức", key = "mid", check1 = false });
            list1.Add(new menu { image = "chiso.png", sao = "sao.png", text1 = "Chỉ số thế giới", key = "mid", check1 = false });
            list1.Add(new menu { image = "nhandinh.png", sao = "sao.png", text1 = "FPTS nhận định", key = "mid", check1 = false });
            list1.Add(new menu { image = "lich.png", sao = "sao.png", text1 = "Lịch sự kiện", key = "mid", check1 = false });
            list1.Add(new menu { image = "dothi.png", sao = "sao.png", text1 = "Biểu đồ", key = "mid", check1 = false });
            list1.Add(new menu { image = "sort.png", sao = "sao.png", text1 = "Giao dịch phát sinh", key = "mid", check1 = false });
            list1.Add(new menu { text = "Giao dịch",key="top" });
            list1.Add(new menu { image = "datlenh.png", sao = "sao.png", text1 = "Đặt lệnh", key="mid", check1 = false });
            list1.Add(new menu { image = "nhandinh.png", sao = "sao.png", text4 = "Báo cáo Giao dịch", key="bot", check1 = false ,check3=true,check4=true,img1="up.png",img="down.png", text3 = "Lệnh trong ngày", text11 = "Lịch sử đặt lệnh", text5 = "Lịch sử ứng trước" });
            list1.Add(new menu { image = "taikhoan.png", sao = "sao.png", text4 = "Quản lý tài khoản", key="bot", check1 = false , check3 = true,check4=true, img1 = "up.png", img = "down.png", text6 = "Sao kê chứng khoán", text7 = "Sao kê tiền", text8 = "Tra cứu phí lưu ký", text9 = "Tra cứu tình trạng chứng quyền", text10 = "Tra cứu biểu phí" });
            list1.Add(new menu { image = "baocao.png", sao = "sao.png", text1 = "Báo cáo tài sản", key="mid", check1 = false });
            list1.Add(new menu { image = "atm.png", sao = "sao.png", text1 = "Bán lô lẻ", key="mid", check1 = false });
            list1.Add(new menu { image = "quyen.png", sao = "sao.png", text1 = "Thực hiện quyền", key="mid", check1 = false });
            list1.Add(new menu { text = "Trợ giúp", key="top" });
            list1.Add(new menu { image = "thongbao.png", sao = "sao.png", text1 = "Thông báo",key="mid", check1 = false });
            list1.Add(new menu { image = "matkhau.png", sao = "sao.png", text1 = "Cài đặt mật khẩu",key="mid", check1 = false });
            list1.Add(new menu { image = "lienhe.png", sao = "sao.png", text1 = "Liên hệ",key="mid", check1 = false });
            list1.Add(new menu { image = "love.png", sao = "sao.png", text1 = "Góp ý",key="mid", check1 = false });
            list1.Add(new menu { image = "book.png", sao = "sao.png", text1 = "Hướng dẫn sử dụng",key="mid", check1 = false });
            list1.Add(new menu { image = "seting.png", sao = "sao.png", text1 = "Cài đặt",key="mid", check1 = false });
            list2 = new ObservableCollection<menu>();
            list2.Add(new menu { text = "Thị trường", key = "top1" });
            list2.Add(new menu { image = "tongquan.png", sao = "sao.png", text1 = "Tổng quan", key = "top2", check1 = true });
            list2.Add(new menu { image = "book.png", sao = "sao.png", text1 = "Bảng Giá", key = "top2", check1 = true });
            list2.Add(new menu { image = "tintuc.png", sao = "sao.png", text1 = "Tin tức", key = "top2", check1 = true });
            list2.Add(new menu { image = "chiso.png", sao = "sao.png", text1 = "Chỉ số thế giới", key = "top2", check1 = true });
            list2.Add(new menu { image = "nhandinh.png", sao = "sao.png", text1 = "FPTS nhận định", key = "top2", check1 = true });
            list2.Add(new menu { image = "lich.png", sao = "sao.png", text1 = "Lịch sự kiện", key = "top2", check1 = true });
            list2.Add(new menu { image = "dothi.png", sao = "sao.png", text1 = "Biểu đồ", key = "top2", check1 = true });
            list2.Add(new menu { image = "sort.png", sao = "sao.png", text1 = "Giao dịch phát sinh", key = "top2", check1 = true });
            list2.Add(new menu { text = "Giao dịch", key = "top1" });
            list2.Add(new menu { image = "datlenh.png", sao = "sao.png", text1 = "Đặt lệnh", key = "top2", check1 = true });
            list2.Add(new menu { image = "nhandinh.png", sao = "sao.png", text1 = "Báo cáo Giao dịch", key = "top3", check1 = true, check3 = true, check4 = true, img1 = "up.png" });
            list2.Add(new menu { image = "taikhoan.png", sao = "sao.png", text1 = "Quản lý tài khoản", key = "top3", check1 = true, check3 = true, check4 = true, img1 = "up.png"});
            list2.Add(new menu { image = "baocao.png", sao = "sao.png", text1 = "Báo cáo tài sản", key = "top2", check1 = true });
            list2.Add(new menu { image = "atm.png", sao = "sao.png", text1 = "Bán lô lẻ", key = "top2", check1 = true });
            list2.Add(new menu { image = "quyen.png", sao = "sao.png", text1 = "Thực hiện quyền", key = "top2", check1 = true });
            list2.Add(new menu { text = "Trợ giúp", key = "top1" });
            list2.Add(new menu { image = "thongbao.png", sao = "sao.png", text1 = "Thông báo", key = "top2", check1 = true });
            list2.Add(new menu { image = "matkhau.png", sao = "sao.png", text1 = "Cài đặt mật khẩu", key = "top2", check1 = true });
            list2.Add(new menu { image = "lienhe.png", sao = "sao.png", text1 = "Liên hệ", key = "top2", check1 = true });
            list2.Add(new menu { image = "love.png", sao = "sao.png", text1 = "Góp ý", key = "top2", check1 = true });
            list2.Add(new menu { image = "book.png", sao = "sao.png", text1 = "Hướng dẫn sử dụng", key = "top2", check1 = true });
            list2.Add(new menu { image = "seting.png", sao = "sao.png", text1 = "Cài đặt", key = "top2", check1 = true });
            list3 = new ObservableCollection<menu>();
            list3.Add(new menu { text = "Yêu Thích", key = "topp" });
            list3.Add(new menu { text = "Thị trường", key = "topp" });
            list3.Add(new menu { image = "tongquan.png", sao = "sao.png", text1 = "Tổng quan", key = "mid1", check1 = false });
            list3.Add(new menu { image = "book.png", sao = "sao.png", text1 = "Bảng Giá", key = "mid1", check1 = false });
            list3.Add(new menu { image = "tintuc.png", sao = "sao.png", text1 = "Tin tức", key = "mid1", check1 = false });
            list3.Add(new menu { image = "chiso.png", sao = "sao.png", text1 = "Chỉ số thế giới", key = "mid1", check1 = false });
            list3.Add(new menu { image = "nhandinh.png", sao = "sao.png", text1 = "FPTS nhận định", key = "mid1", check1 = false });
            list3.Add(new menu { image = "lich.png", sao = "sao.png", text1 = "Lịch sự kiện", key = "mid1", check1 = false });
            list3.Add(new menu { image = "dothi.png", sao = "sao.png", text1 = "Biểu đồ", key = "mid1", check1 = false });
            list3.Add(new menu { image = "sort.png", sao = "sao.png", text1 = "Giao dịch phát sinh", key = "mid1", check1 = false });
            list3.Add(new menu { text = "Giao dịch", key = "topp" });
            list3.Add(new menu { image = "datlenh.png", sao = "sao.png", text1 = "Đặt lệnh", key = "mid1", check1 = false });
            list3.Add(new menu { image = "nhandinh.png", sao = "sao.png", text1 = "Báo cáo Giao dịch", key = "bot1", check1 = false, check3 = true, check4 = true, img1 = "up.png", img = "down.png", text3 = "Lệnh trong ngày", text11 = "Lịch sử đặt lệnh", text5 = "Lịch sử ứng trước" });
            list3.Add(new menu { image = "taikhoan.png", sao = "sao.png", text1 = "Quản lý tài khoản", key = "bot1", check1 = false, check3 = true, check4 = true, img1 = "up.png", img = "down.png", text6 = "Sao kê chứng khoán", text7 = "Sao kê tiền", text8 = "Tra cứu phí lưu ký", text9 = "Tra cứu tình trạng chứng quyền", text10 = "Tra cứu biểu phí" });
            list3.Add(new menu { image = "baocao.png", sao = "sao.png", text1 = "Báo cáo tài sản", key = "mid1", check1 = false });
            list3.Add(new menu { image = "atm.png", sao = "sao.png", text1 = "Bán lô lẻ", key = "mid1", check1 = false });
            list3.Add(new menu { image = "quyen.png", sao = "sao.png", text1 = "Thực hiện quyền", key = "mid1", check1 = false });
            list3.Add(new menu { text = "Trợ giúp", key = "topp" });
            list3.Add(new menu { image = "thongbao.png", sao = "sao.png", text1 = "Thông báo", key = "mid1", check1 = false });
            list3.Add(new menu { image = "matkhau.png", sao = "sao.png", text1 = "Cài đặt mật khẩu", key = "mid1", check1 = false });
            list3.Add(new menu { image = "lienhe.png", sao = "sao.png", text1 = "Liên hệ", key = "mid1", check1 = false });
            list3.Add(new menu { image = "love.png", sao = "sao.png", text1 = "Góp ý", key = "mid1", check1 = false });
            list3.Add(new menu { image = "book.png", sao = "sao.png", text1 = "Hướng dẫn sử dụng", key = "mid1", check1 = false });
            list3.Add(new menu { image = "seting.png", sao = "sao.png", text1 = "Cài đặt", key = "mid1", check1 = false });
        }

        private void Click1(object obj)
        {
            
        }


        public bool test;
        private void Click(object obj)
        {
            
            var mn = obj as menu;
            if (mn.check2 == false)
            {
                
                mn.check2 = true;
                mn.sao = "saovang.png";
                mn.check3 = false;
                mn.key = "mid1";
                var a = mn.text1;
                //list3.Add(new menu { image = mn.image, text1 = mn.text1, key = mn.key , text4 =mn.text4});
                
                for (var i = list3.Count - 1; i >= 0; i--)
                {
                    if (list3[i].text1 == a )
                    {
                        list3.RemoveAt(i);
                    }
                    if (list3[i].sao == "saovang.png")
                    {
                        App.test1 = true;
                    }
                    if (list3[i].sao == "sao.png")
                    {
                        App.test1 = false;
                    }
                }
                list3.Insert(1, mn);
            }
            else
            {
               
                mn.check2 = false;
                mn.sao = "sao.png";
                mn.check3 = true;
                for (var i = list3.Count - 1; i >= 0; i--)
                {
                    if (list3[i].sao=="saovang.png")
                    {
                        App.test1 = true;
                    }
                    if (list3[i].sao == "sao.png")
                    {
                        App.test1 = false;
                    }
                }
            }

        }
    }
}
