using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fpts.Models
{
    public class menu : BindableBase
    {
        private string _text;
        private string _image;
        private string _img;
        private string _sao;
        private bool _check1;
        private bool _check2;
        private bool _check4;
        private bool _check5;
        private bool _check6;
       
        public string text1 { get; set; }
        public bool check1 { get => _check1; set => SetProperty(ref _check1, value); }
        public bool check2 { get => _check2; set => SetProperty(ref _check2, value); }
        public string text2 { get; set; }
        public string text3 { get; set; }
        public string text4 { get; set; }
        public string text11 { get; set; }
        public string text5 { get; set; }
        public string text6 { get; set; }
        public string text7 { get; set; }
        public string text8 { get; set; }
        public string text9 { get; set; }
        public string text10 { get; set; }
        public string key { get; set; }
        public bool check3 { get; set; }
        public bool check4 { get => _check4; set => SetProperty(ref _check4, value); }
        public bool check5 { get => _check5; set => SetProperty(ref _check5, value); }
        public bool check6 { get => _check6; set => SetProperty(ref _check6, value); }
        public string img { get => _img; set => SetProperty(ref _img, value); }
        public string img1 { get; set; }
        public string text { get => _text; set => SetProperty(ref _text, value); }
        public string image { get => _image; set => SetProperty(ref _image, value); }
        public string sao { get => _sao; set => SetProperty(ref _sao, value); }
    }
}
