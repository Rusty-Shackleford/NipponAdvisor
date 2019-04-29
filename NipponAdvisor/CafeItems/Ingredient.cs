using System.Collections.Generic;

namespace NipponAdvisor.CafeItems
{
    public class Ingredient
    {
        public string Name { get; set; }
        public int Rating { get; set; }

        // Stat Fields
        public Quality QualityInfo { get; set; }


        public Ingredient()
        {
            QualityInfo = new Quality();
        }
    }
}
