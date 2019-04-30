using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NipponAdvisor.CafeItems
{
    public class IngredientList
    {
        #region [ Fields ]
        public List<Ingredient> All { get; }

        public int CategoryCount { get; }
        public IEnumerable<Category> Categories { get; }

        public IEnumerable<IGrouping<Category, Ingredient>> ByCategory { get; }

        #endregion


        #region [ Constructor ]
        public IngredientList(string json)
        {
            // Load ingredient data
            All = JsonConvert.DeserializeObject<List<Ingredient>>(json);

            // Create a unique list of categories.
            Categories = All.Select(c => c.Category).Distinct();
            CategoryCount = Categories.Count();

            // Create a grouping of ingredients by category
            ByCategory = from ingredient in All
                        group ingredient by ingredient.Category;
        }
        #endregion
    }
}