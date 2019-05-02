using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NipponAdvisor.CafeItems
{
    public class CraftedDish
    {
        #region [ Fields ]
        public Dish BaseDish { get; set; }
        public QualitySet Quality { get; set; }
        public string CustomName { get; set; }
        public Ingredient CookIngredient1 { get; set; }
        public Ingredient CookIngredient2 { get; set; }
        #endregion

        #region [ Constructor ]
        public CraftedDish(Dish dish)
        {
            BaseDish = dish;
            Quality = new QualitySet();
        }
        #endregion

        #region [ Ready ]
        public bool Ready()
        {
            if (BaseDish == null)
                return false;
            if (Quality == null)
                return false;

            if (CookIngredient1 == null)
                return false;
            if (CookIngredient2 == null)
                return false;

            return true;
        }
        #endregion

        #region [ Cook ]
        public void Cook()
        {
            //// Apply Ingredient 1
            //if (CookIngredient1 != null)
            //{
            //    foreach (var Property in CookIngredient1.QualityInfo.Attributes)
            //        QualityInfo.Attributes[Property.Key] += Property.Value;

            //    if (CookIngredient2 != null)
            //    {
            //        foreach (var Property in CookIngredient2.QualityInfo.Attributes)
            //            QualityInfo.Attributes[Property.Key] += Property.Value;
            //    }
            //}

        }
        #endregion
    }
}
