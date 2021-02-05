using Fpts.ViewModel;
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
            
        }
        
        public bool test;
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            test = !test;
            var vm = (MasterDetailMainviewMasterViewModel)BindingContext;
            
            foreach(var item in vm.list1)
            {
                if (test == true)
                {
                    item.check1 = true;
                    item.check4 = false;
                    setup.IsVisible = false;
                    power.IsVisible = false;
                    tick.IsVisible = true;
                    
                }
                
            }
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            test = !test;
            var vm = (MasterDetailMainviewMasterViewModel)BindingContext;
            
            foreach (var item in vm.list1)
            {
                if (test == false && item.sao=="saovang.png")
                {
                    item.check1 = false;
                    item.check4 = true;
                    setup.IsVisible = true;
                    power.IsVisible = true;
                    tick.IsVisible = false;
                    listview.IsVisible = false;
                    listview1.IsVisible = true;
                }

            }
        }
    }
}
    