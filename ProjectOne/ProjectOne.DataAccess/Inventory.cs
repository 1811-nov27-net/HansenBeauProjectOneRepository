using System;
using System.Collections.Generic;

namespace ProjectOne.DataAccess
{
    public partial class Inventory
    {
        public int InventoryId { get; set; }
        public int IngredientId { get; set; }
        public int StoreId { get; set; }
        public int QtyRemaining { get; set; }

        public virtual Ingredient Ingredient { get; set; }
        public virtual Store Store { get; set; }
    }
}
