using Fpts.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
namespace Fpts.ViewModel
{
    public class Selected2 : DataTemplateSelector
    {
        public DataTemplate topp { get; set; }
        public DataTemplate mid1 { get; set; }
        public DataTemplate bot1 { get; set; }
        public DataTemplate bot2 { get; set; }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var Me = (menu)item;


            if (Me.key == "topp")
            {
                return topp;
            }
            if (Me.key == "mid1")
            {
                return mid1;
            }
            if (Me.key == "bot1")
            {
                return bot1;
            }
            else
                return bot2;
        }
    }
}