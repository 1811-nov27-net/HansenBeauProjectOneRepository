using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOne.Library
{
    public class Inventory
    {
        public int InventoryID { get; set; }

        public int IngredientID { get; set; }

        public int StoreID { get; set; }

        public int QtyRemaining { get; set; }

        // navigation property for Models.Ingredient
        public List<Ingredient> Ingredient { get; set; } = new List<Ingredient>();

        // navigation property for Models.Store
        public List<Store> Store { get; set; } = new List<Store>();
    }
}
