using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Fpts.Models
{
    public class CoPhieuModel : BindableBase
    {
        private bool _checkShowSao;
        private bool _check8;
        public bool check8 { get => _check8; set => SetProperty(ref _check8, value); }
        public bool CheckShowSao { get => _checkShowSao; set => SetProperty(ref _checkShowSao, value); }
        /// <summary>
        /// kiem tra sao
        /// </summary>
        private string _imgSao;
        public string imgSao { get => _imgSao; set => SetProperty(ref _imgSao, value); }
        /// <summary>
        /// hiển thị sao
        /// </summary>
        public string MaChiSo { get; set; }//mã chỉ số viet hoa chu cai dau tien neu de public
        public double ThayDoiOne { get; set; }//thay đổi
        public string GiaChiSo { get; set; }//giá chỉ số
        public string ThayDoiTow { get; set; }//thay đổi %
        public string GiaTri { get; set; }//giá trị chỉ số
        public string ColorNumber { get; set; }//màu sắc chỉ số
        public string MaChungkhoan { get; set; }//mã chứng khoán
        public string GiaChungKhoan { get; set; }//giá chứng khoán
        public double TangGiamOne { get; set; }//+/-
        public double TangGiamTow { get; set; }//+-(%)
        public string KhoiLuong { get; set; }//khối lương dùng chung 2 bảng
        public string ColorMa { get; set; }//màu mã chứng khoán

       
        
     
        
        
        
        public bool CheckTangGiamOne { get; set; }//hiển thị tăng giảm thường
        public bool CheckTangGiamTow { get; set; }//hiển thị tăng %
        public bool CheckThayDoiOne { get; set; }//hiển thị thay đổi
        public bool CheckThayDoiTow { get; set; }//hiển thị thay đổi %
        public bool CheckShowKhoiLuong { get; set; }//hiển thị Khối lượng
        public bool CheckShowGia { get; set; }//hiển thị giá
        
    }
}
