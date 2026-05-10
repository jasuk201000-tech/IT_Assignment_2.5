using System;
using System.Globalization;

namespace IT_Assessment_2.Models
{
    public class OrderItem
    {
        // CSV columns: OrderItemID, OrderID, VariantID, ProductName, Size,
        //              Quantity, UnitPrice, LineTotal

        public int OrderItemID { get; set; }
        public int OrderID { get; set; }
        public int VariantID { get; set; }

        public string ProductName { get; set; }
        public string Size { get; set; }

        private int _quantity;
        public int Quantity
        {
            get => _quantity;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Quantity must be greater than 0.");
                _quantity = value;
            }
        }

        public decimal UnitPrice { get; set; }
        public decimal LineTotal { get; set; }

        // build an OrderItem from a CSV row (one line of order_items.csv,
        // already split on commas)
        public static OrderItem FromCsv(string[] f)
        {
            return new OrderItem
            {
                OrderItemID = int.Parse(f[0]),
                OrderID = int.Parse(f[1]),
                VariantID = int.Parse(f[2]),
                ProductName = f[3],
                Size = f[4],
                Quantity = int.Parse(f[5]),
                UnitPrice = decimal.Parse(f[6], CultureInfo.InvariantCulture),
                LineTotal = decimal.Parse(f[7], CultureInfo.InvariantCulture),
            };
        }
    }
}
