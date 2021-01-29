using Fpts.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace Fpts.ViewModel
{
    public class thitruongViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Banggia> HSX { get; set; }
        public ObservableCollection<Banggia> HNX { get; set; }
        public Command<object> ClickCommand { get; set; }

        

        public event PropertyChangedEventHandler PropertyChanged;

        public thitruongViewModel()
        {
            HSX = App.HSX;
            HNX = App.HNX;
            ClickCommand = new Command<object>(Click);
        }

        private void Click(object obj)
        {
            
            if (App.test == true)//HSX
            {
                
                var mn = obj as Banggia;
                if (mn.check5 == false)
                {
                    mn.check5 = true;
                    mn.img = "saovang.png";
                }
                else
                {
                    mn.check5 = false;
                    mn.img = "sao.png";
                }
            }
            else
            {
                
                var mn = obj as Banggia;//HSX
                if (mn.check5 == false)
                {
                    mn.check5 = true;
                    mn.img = "saovang.png";
                }
                else
                {
                    mn.check5 = false;
                    mn.img = "sao.png";
                }
            }


        }
    }

    
    
}
