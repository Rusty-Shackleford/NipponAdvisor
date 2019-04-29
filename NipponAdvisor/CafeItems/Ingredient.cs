using System.Collections.Generic;

namespace NipponAdvisor.CafeItems
{
    public enum IngredientCategory
    {
        Fish,
        Grains_Misc,
        Luxury,
        Meat_Dairy,
        Seasonings,
        Veggies,
    }

    public class Ingredient
    {
        public string Name { get; set; }
        public int Rating { get; set; }
        public int Health { get; set; }
        public int Brain { get; set; }
        public int Texture { get; set; }
        public int Armoa { get; set; }
        public int Appearance { get; set; }
        public int Volume { get; set; }
        public int Rarity { get; set; }
        public int Charisma { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }


        public Ingredient()
        {
        }
    }
}
