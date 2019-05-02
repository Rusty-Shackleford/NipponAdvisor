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
        public int Rating { get; set; }
        public Ingredient CookIngredient1 { get; set; }
        public Ingredient CookIngredient2 { get; set; }

        public string Name { get { return BaseDish.Name; } }
        public int Health { get; set; }
        public int Brain { get; set; }
        public int Texture { get; set; }
        public int Aroma { get; set; }
        public int Appearance { get; set; }
        public int Volume { get; set; }
        public int Rarity { get; set; }
        public int Charisma { get; set; }
        #endregion

        #region [ Constructor ]
        public CraftedDish(Dish dish)
        {
            BaseDish = dish;
            Rating = 1;
        }
        #endregion

        #region [ Ready ]
        public bool Ready()
        {
            if (BaseDish == null)
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
