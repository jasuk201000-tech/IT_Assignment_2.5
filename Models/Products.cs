using System;
using System.Collections.Generic;
using System.Linq;

namespace IT_Assessment_2.Models
{
    // singular - one product
    public class Product
    {
        // CSV columns: ProductID, ProductName, CategoryID, Description,
        //              BasePrice, Brand, ImagePath, Active, DateAdded

        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public CategoryID Category { get; set; }      // renamed from CategoryID to avoid name collision
        public string Description { get; set; } = string.Empty;
        public decimal BasePrice { get; set; }
        public string Brand { get; set; }
        public string ImagePath { get; set; }
        public bool Active { get; set; } = true;
        public DateTime DateAdded { get; set; } = DateTime.Today;

        // variants attached to this product (loaded separately from variants.csv)
        public List<Variant> Variants { get; set; } = new List<Variant>();

        // computed properties — used by the inventory KPI tiles
        public int TotalStock => Variants.Sum(v => v.StockLevel);
        public decimal MinPrice => BasePrice;   // single price model — all variants share BasePrice
        public bool HasLowStock => Variants.Any(v => v.IsLowStock);
        public bool HasOutOfStock => Variants.Any(v => v.IsOutOfStock);
    }

    // singular - one variant
    public class Variant
    {
        // CSV columns: VariantID, ProductID, Size, Color, SKU, StockLevel, ReorderLevel

        public int VariantID { get; set; }
        public int ProductID { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public string SKU { get; set; }
        public int StockLevel { get; set; }
        public int ReorderLevel { get; set; }

        // computed properties
        public bool IsLowStock => StockLevel > 0 && StockLevel <= ReorderLevel;
        public bool IsOutOfStock => StockLevel <= 0;
    }

    // enumerated categories
    public enum CategoryID
    {
        Dresses = 1,
        Tops = 2,
        Bottoms = 3,
        Outerwear = 4,
        Accessories = 5,
        Footwear = 6
    }
}
