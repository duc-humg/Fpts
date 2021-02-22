using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fpts.Models
{
    public class DanhMucModel : BindableBase
    {
        private string _notetext;
        private string _image;
        public string NameDanhMuc { get => _notetext; set => SetProperty(ref _notetext, value); }
        public string Image { get => _image; set => SetProperty(ref _image, value); }
    }
}
