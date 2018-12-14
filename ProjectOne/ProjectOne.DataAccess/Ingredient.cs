using System;
using System.Collections.Generic;

namespace ProjectOne.DataAccess
{
    public partial class Ingredient
    {
        public Ingredient()
        {
            Inventory = new HashSet<Inventory>();
            ProductRecipe = new HashSet<ProductRecipe>();
        }

        public int IngredientId { get; set; }
        public string IngredientName { get; set; }
        public decimal IngredientPrice { get; set; }

        public virtual ICollection<Inventory> Inventory { get; set; }
        public virtual ICollection<ProductRecipe> ProductRecipe { get; set; }
    }
}
