using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fpts.Models
{
    public class MenuModel : BindableBase
    {
        private string _textKeyMid;
        private string _textKeyTop;
        private string _image;
        private string _sao;
        private bool _checkSao;
        private bool _checkSaoVang;
        private bool _checkNutThemSuKien;
        private bool _checkSuKienKeoDai;
        
        
        public bool CheckSao { get => _checkSao; set => SetProperty(ref _checkSao, value); }
        public bool CheckSaoVang { get => _checkSaoVang; set => SetProperty(ref _checkSaoVang, value); }
        
        public string TextKeyBotOne { get; set; }
        public string TextKeyBot { get; set; }
        public string TextKeyBotTow { get; set; }
        public string TextKeyBotThree { get; set; }
        public string TextKeyBotFour { get; set; }
        public string TextKeyBotFive { get; set; }
        public string TextKeyBotSix { get; set; }
        public string TextKeyBotSeven { get; set; }
        public string TextKeyBotEight { get; set; }
        public string Key { get; set; }
        
       
        public bool CheckNutThemSuKien { get => _checkNutThemSuKien; set => SetProperty(ref _checkNutThemSuKien, value); }
        public bool CheckSuKienKeoDai { get => _checkSuKienKeoDai; set => SetProperty(ref _checkSuKienKeoDai, value); }
        public string TextKeyMid { get => _textKeyMid; set => SetProperty(ref _textKeyMid, value); }
        public string TextKeyTop { get => _textKeyTop; set => SetProperty(ref _textKeyTop, value); }
        public string Sao { get => _sao; set => SetProperty(ref _sao, value); }
        public string Image { get => _image; set => SetProperty(ref _image, value); }
    }
}
