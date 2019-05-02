using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NipponAdvisor.CafeItems
{
    public class IngredientsTable
    {
        #region [ Fields ]
        public List<Ingredient> Records { get; }

        public int CategoryCount { get; }
        public IEnumerable<Category> Categories { get; }

        public IEnumerable<IGrouping<Category, Ingredient>> ByCategory { get; }

        #endregion


        #region [ Constructor ]
        public IngredientsTable(string json)
        {
            // Load ingredient data
            Records = JsonConvert.DeserializeObject<List<Ingredient>>(json);

            // Create a unique list of categories.
            Categories = Records.Select(c => c.Category).Distinct();
            CategoryCount = Categories.Count();

            // Create a grouping of ingredients by category
            ByCategory = from ingredient in Records
                        group ingredient by ingredient.Category;
        }
        #endregion
    }
}