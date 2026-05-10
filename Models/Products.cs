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

        // enumerates categories for easier accessibility
        public enum CategoryID
        {
            Dresses = 1,
            Tops = 2,
            Bottoms = 3,
            Outerwear = 4,
            Accessories = 5,
            Footwear = 6
        }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; } = string.Empty;

        public decimal BasePrice { get; set; }

        public string Brand { get; set; }

        public bool Active { get; set; } = true;

        public DateTime DateAdded { get; set; } = DateTime.Today;
    }
}
