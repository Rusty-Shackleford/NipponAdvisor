using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace NipponAdvisor.CafeItems
{

    #region [ Enum: Category ]
    public enum Category
    {
        Fish,
        Fruit,
        Grains_Misc,
        Luxury,
        Meat_Dairy,
        Seasonings,
        Veggies,
    }
    #endregion


    public class Ingredient
    {
        #region [ Fields ]
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

        [JsonProperty("Category")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Category Category { get; set; }

        public int Price { get; set; }
        #endregion


        #region [ Constructor ]
        public Ingredient() { }
        #endregion
    }
}
