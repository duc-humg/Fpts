using Fpts.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Fpts.ViewModel
{
    public class Selected : DataTemplateSelector
    {
        public DataTemplate Top { get; set; }
        public DataTemplate Mid { get; set; }
        public DataTemplate Bot { get; set; }
        public DataTemplate sp { get; set; }
        public DataTemplate jungle { get; set; }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var Me = (MenuModel)item;
            

            if (Me.Key=="top")
            {
                return Top;
            }
            if (Me.Key=="mid")
            {
                return Mid;
            }
            if (Me.Key == "sp")
            {
                return sp;
            }
            else
                return Bot;
        }
    }
}