using Fpts.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace Fpts.ViewModel
{
    public class PageThiTruongViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<CoPhieuModel> HSX { get; set; }
        public ObservableCollection<CoPhieuModel> HNX { get; set; }
        public Command<object> ClickHienThiSaoCommand { get; set; }
        //public Command<object> ClickThayDoiCommand { get; set; }
        //public string lblThayDoi { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;

        public PageThiTruongViewModel()
        {
            HSX = App.ListHSX;
            HNX = App.ListHNX;
            ClickHienThiSaoCommand = new Command<object>(ClickHienThiSao);
            //ClickThayDoiCommand = new Command<object>(ClickThayDoi);
        }

        //private void ClickThayDoi(object obj)
        //{
        //    if (App.ListHSX == HNX)
        //    {

        //    }
        //}

        private void ClickHienThiSao(object obj)
        {
            if (App.test == true)//HSX
            {
                var mn = obj as CoPhieuModel;
                if (mn.CheckShowSao == false)
                {
                    mn.CheckShowSao = true;
                    mn.imgSao = "saovang.png";
                }
                else
                {
                    mn.CheckShowSao = false;
                    mn.imgSao = "sao.png";
                }
            }
        }
    }
}
