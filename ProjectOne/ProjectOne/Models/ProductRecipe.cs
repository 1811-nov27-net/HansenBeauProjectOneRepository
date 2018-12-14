using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOne.Models
{
    public class ProductRecipe
    {
        public int ProductRecipeID { get; set; }

        public int IngredientID { get; set; }

        public int ProductID { get; set; }

        public int IngredientQty { get; set; }

        // navigation property for Models.Product
        public List<Product> Product { get; set; } = new List<Product>();

        // navigation property for Models.Ingredient
        public List<Ingredient> Ingredient { get; set; } = new List<Ingredient>();
    }
}
