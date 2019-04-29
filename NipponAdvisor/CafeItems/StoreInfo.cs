using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NipponAdvisor.CafeItems
{
    public class StoreInfo
    {
        #region [ Fields ]
        public List<Ingredient> PlayerStock { get; set; }
        public List<Dish> PlayerDishes { get; set; }
        #endregion

        #region [ Constructor ]
        public StoreInfo()
        {
            PlayerStock = new List<Ingredient>();
            PlayerDishes = new List<Dish>();
        }
        #endregion
    }
}
