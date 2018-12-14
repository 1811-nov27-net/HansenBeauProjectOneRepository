using System;
using System.Collections.Generic;

namespace ProjectOne.DataAccess
{
    public partial class ProductRecipe
    {
        public int ProductRecipeId { get; set; }
        public int IngredientId { get; set; }
        public int ProductId { get; set; }
        public int IngredientQty { get; set; }

        public virtual Ingredient Ingredient { get; set; }
        public virtual Product Product { get; set; }
    }
}
