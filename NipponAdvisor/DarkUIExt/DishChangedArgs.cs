using NipponAdvisor.CafeItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NipponAdvisor.DarkUIExt
{
    public class DishChangedArgs : EventArgs
    {
        public Dish NewDish { get; set; }
        public DishChangedArgs(Dish dish)
        {
            NewDish = dish;
        }
    }
}
