using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Fpts.ViewModel
{
    class BaseModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
