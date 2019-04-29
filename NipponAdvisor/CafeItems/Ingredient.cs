using System.Collections.Generic;

namespace NipponAdvisor.CafeItems
{
    public enum IngredientCategory
    {
        Seasonings,
        Veggies,
        Grains,
        Fruit,
        Fish
    }

    public class Ingredient
    {
        public string Name { get; set; }
        public int Rating { get; set; }
        public IngredientCategory Category { get; set; }
        public string Shelf { get; set; }
        // Stat Fields
        public Quality QualityInfo { get; set; }


        public Ingredient()
        {
            QualityInfo = new Quality();
        }
    }
}
