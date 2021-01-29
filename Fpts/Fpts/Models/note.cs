using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fpts.Models
{
    public class note : BindableBase
    {
        private string _notetext;
        private string _image;
        public string notetext { get => _notetext; set => SetProperty(ref _notetext, value); }
        public string image { get => _image; set => SetProperty(ref _image, value); }
    }
}
