using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Fpts.Models
{
    public class Banggia : BindableBase
    {
        private bool _check5;
        private bool _check8;
        private string _img;
        public string Ma { get; set; }
        public double sogd { get; set; }
        public string thaydoi { get; set; }
        public string thaydoi1 { get; set; }
        public string monney { get; set; }
        public string color { get; set; }
        public string ma { get; set; }
        public string gia { get; set; }
        public double phantram { get; set; }
        public double phantram1 { get; set; }
        public string khoiluong { get; set; }
        public string mau { get; set; }

        public bool check1 { get; set; }
        public bool check2 { get; set; }
        public bool check3 { get; set; }
        public bool check4 { get; set; }
        public bool check5 { get => _check5; set => SetProperty(ref _check5, value); }
        public bool check8 { get => _check8; set => SetProperty(ref _check8, value); }
        public bool check6 { get; set; }
        public bool check7 { get; set; }
        public string img { get => _img; set => SetProperty(ref _img, value); }
    }
}
