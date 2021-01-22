using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fpts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailMainviewMaster : ContentPage
    {
        public ListView ListView;

        public MasterDetailMainviewMaster()
        {
            InitializeComponent();

            BindingContext = new MasterDetailMainviewMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MasterDetailMainviewMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterDetailMainviewMasterMenuItem> MenuItems { get; set; }

            public MasterDetailMainviewMasterViewModel()
            {
                MenuItems = new ObservableCollection<MasterDetailMainviewMasterMenuItem>(new[]
                {
                    new MasterDetailMainviewMasterMenuItem { Id = 0, Title = "Page 1" },
                    new MasterDetailMainviewMasterMenuItem { Id = 1, Title = "Page 2" },
                    new MasterDetailMainviewMasterMenuItem { Id = 2, Title = "Page 3" },
                    new MasterDetailMainviewMasterMenuItem { Id = 3, Title = "Page 4" },
                    new MasterDetailMainviewMasterMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}