using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Assessment_2.Models
{
    public class Products
    {
       
        // to implement: ProductID,ProductName,CategoryID,Description,BasePrice,Brand,ImagePath,Active,DateAdded

        // enumerated categories for easier accessibility
        public enum CategoryID
        {
            Dresses = 1,
            Tops = 2,
            Bottoms = 3,
            Outerwear = 4,
            Accessories = 5,
            Footwear = 6
        }
        public Guid ProductID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; } = string.Empty;

        public decimal BasePrice { get; set; }

        public string Brand { get; set; }

        public bool Active { get; set; } = true;

        public DateTime DateAdded { get; set; } = DateTime.Today;

        public List<ProductVariant> Variants { get; set; } = new();
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public int TotalStock => Variants.Sum(v => v.StockQty); // implementing low stock threshold for KPI
        public decimal MinPrice => Variants.Count > 0
                                        ? Variants.Min(v => v.Price)
                                        : 0m;
        public bool HasLowStock => Variants.Any(v => v.IsLowStock);
        public bool HasOutOfStock => Variants.Any(v => v.IsOutOfStock);
    }

    public class Variants
    {
        // to implement: VariantID,ProductID,Size,Color,SKU,StockLevel,ReorderLevel

        public Guid VariantID { get; set; }
        public Guid ProductID { get; set; }

        public string Size { get; set; }

        public string Color { get;set; }

        public string SKU { get; set; }

        public int StockLevel { get; set; } = 0;

        public int ReorderLevel { get; set; } = 0;
    }
}
