using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NipponAdvisor.CafeItems
{
    /// <summary>
    /// This should probably be it's own Implementation of a collection, but 
    /// in this case I think it's ok.  :)
    /// </summary>
    public class Quality
    {
        public Dictionary<string, int> Attributes { get; set; }

        #region [ Constructors ]
        // Empty Stats
        public Quality() : this(null) { }


        public Quality(Quality copyFrom)
        {
            Attributes = new Dictionary<string, int>();

            // Copy from another Item's stats
            if (copyFrom != null)
            {
                foreach (var property in copyFrom.Attributes)
                    Attributes.Add(property.Key, property.Value);
            }
            else
            {
                Attributes.Add("Health", 0);
                Attributes.Add("Brain", 0);
                Attributes.Add("Texture", 0);
                Attributes.Add("Armoa", 0);
                Attributes.Add("Appearance", 0);
                Attributes.Add("Volume", 0);
                Attributes.Add("Rarity", 0);
                Attributes.Add("Charisma", 0);
            }
        }
        #endregion
    }
}
