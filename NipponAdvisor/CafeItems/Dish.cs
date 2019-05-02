using System.Linq;

namespace NipponAdvisor.CafeItems
{
    public class Dish
    {
        #region [ Fields ]
        // Dish Information
        public string Name { get; set; }
        public int BaseRating { get; set; }
        public string DerivedDish { get; set; }
        public string RecipeIngredient1 { get; set; }
        public string RecipeIngredient2 { get; set; }
        public int MaxPrice { get; set; }
        public string PriceRating { get; set; }
        public int MaxTaste { get; set; }
        public string TasteRating { get; set; }
        public int MaxAppeal { get; set; }
        public string AppealRating { get; set; }
        public int CostPerMonth { get; set; }
        public bool Craftable { get; set; }
        public string Source { get; set; }
        #endregion

        #region [ Description Fields ]
        public string PriceDescription
        {
            get { return $"$ {MaxPrice} / {PriceRating}"; }
        }

        public string CostPerMonthDescription
        {
            get { return $"$ {CostPerMonth.ToString()}"; }
        }

        public string TasteDescription
        {
            get { return $"{MaxTaste} / {TasteRating}"; }
        }

        public string AppealDescription
        {
            get { return $"{MaxAppeal} / {AppealRating}"; }
        }

        public string Note
        {
            get
            {
                if (!Craftable)
                    return $"Can only be obtained by: {GetSourceDescription()}";
                return "";
            }
        }

        public string RecipeDescription
        {
            get
            {
                string returnString = "";
                if (!string.IsNullOrEmpty(DerivedDish))
                {
                    returnString += $"[{DerivedDish}]\n +({RecipeIngredient1})";
                    if (!string.IsNullOrEmpty(RecipeIngredient2))
                    {
                        returnString += $"\n +({RecipeIngredient2})";
                    }
                }
                else
                {
                    returnString = "See note.";
                }
                return returnString;
            }
        }

        private string GetSourceDescription()
        {
            var elem = Source.Split('|').ToList();
            string retString = "";
            foreach (var item in elem)
            {
                string source = "\n - " + item;
                source = source.Replace(")", "");
                source = source.Replace("(", "");
                source = source.Replace(":", " : ");
                retString += source;
            }
            return retString;
        }
        #endregion



        // Stat Fields

        public Dish() { }
    }


}
