using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using Fpts.Models;
using Xamarin.Forms;
using Fpts.Views;
using System.ComponentModel;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace Fpts.ViewModel
{
    public class datlenhViewmodel : BindableBase
    {
        public ObservableCollection<DatLenhModel> listlenh { get; set; }

        private string _ma;
        private string _tenct;
        private string _TC;
        private string _san;
        private string _tran;
        private string _mua1;
        private string _khop;
        private string _ban1;
        
        public string tenct { get => _tenct; set => SetProperty(ref _tenct, value); }
        public string ma { get => _ma; set => SetProperty(ref _ma, value); }
        public string tran { get => _tran; set => SetProperty(ref _tran, value); }
        public string TC { get => _TC; set => SetProperty(ref _TC, value); }
        public string san { get => _san; set => SetProperty(ref _san, value); }
        public string mua1 { get => _mua1; set => SetProperty(ref _mua1, value); }
        public string khop { get => _khop; set => SetProperty(ref _khop, value); }
        public string ban1 { get => _ban1; set => SetProperty(ref _ban1, value); }
        public string max { get; set; }
        public datlenhViewmodel()
        {
            listlenh = new ObservableCollection<DatLenhModel>();
            listlenh.Add(new DatLenhModel { ma1 = "FPT", tenct1 = "HOUSE - Công ty Cổ phần FPT", tran1 = "83.6", TC1 = "78.2", san1 = "72.8", mua11 = "77.9", khop1 = "78.2", ban11 = "78.2"});
            listlenh.Add(new DatLenhModel { ma1 = "VIC", tenct1 = "HOUSE - Công ty Cổ phần Vingroup", tran1 = "83.6", TC1 = "78.2", san1 = "72.8", mua11 = "77.9", khop1 = "78.2", ban11 = "78.2"});
            listlenh.Add(new DatLenhModel { ma1 = "VFT", tenct1 = "HOUSE - Công ty Cổ phần FPT", tran1 = "83.6", TC1 = "78.2", san1 = "72.8", mua11 = "77.9", khop1 = "78.2", ban11 = "78.2"});
        }
    }
}
