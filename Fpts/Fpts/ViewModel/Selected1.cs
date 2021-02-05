using Fpts.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
namespace Fpts.ViewModel
{
    public class Selected1 : DataTemplateSelector
    {
        public DataTemplate top1 { get; set; }
        public DataTemplate top2 { get; set; }
        public DataTemplate top3 { get; set; }
        public DataTemplate top4 { get; set; }
        public DataTemplate jungle { get; set; }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var Me = (menu)item;


            if (Me.key == "top1")
            {
                return top1;
            }
            if (Me.key == "top2")
            {
                return top2;
            }
            if (Me.key == "top3")
            {
                return top3;
            }
            else
                return top4;
        }
    }
}

