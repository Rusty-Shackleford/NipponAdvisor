using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NipponAdvisor.CafeItems
{
    public class DishTable
    {

        #region [ Members ]
        public List<Dish> Records { get; }
        #endregion


        #region [ Constructor ]
        public DishTable(string json)
        {
            Records = JsonConvert.DeserializeObject<List<Dish>>(json);
        }
        #endregion

        #region [ GetDishByName ]
        public Dish GetDishByName(string name)
        {
            return Records.FirstOrDefault(d => d.Name == name);
        }
        #endregion


    }
}
