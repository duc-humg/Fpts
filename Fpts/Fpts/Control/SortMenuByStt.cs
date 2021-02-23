using Fpts.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fpts.Control
{
    class SortMenuByStt : IComparer<MenuModel>
    {
        public int Compare( MenuModel x, MenuModel y)
        {
            return x.stt.CompareTo(y.stt);
        }
    }
}
