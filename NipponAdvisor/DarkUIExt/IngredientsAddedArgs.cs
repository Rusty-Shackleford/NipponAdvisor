using System;
using System.Collections.Generic;

namespace NipponAdvisor.DarkUIExt
{
    public class IngredientsAddedArgs : EventArgs
    {
        public List<string> Ingredients { get; set; }
        public IngredientsAddedArgs(List<string> ingredients)
        {
            Ingredients = ingredients;
        }
    }
}
