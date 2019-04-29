namespace NipponAdvisor.CafeItems
{
    public class Dish
    {
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

        // Stat Fields

        public Dish() { }
    }

    
}
