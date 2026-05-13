using IT_Assessment_2.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using static IT_Assessment_2.Models.Staff;

namespace IT_Assessment_2.CSVs
{
    public static class CsvHelper
    {
        // reads CSV files without reading the header row
        public static List<string[]> ReadRows(string path)
        {
            var rows = new List<string[]>();
            string[] lines = File.ReadAllLines(path);

            for (int i = 1; i < lines.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lines[i])) continue;
                rows.Add(lines[i].Split(','));
            }
            return rows;
        }

        // staff
        public class Staff
        {
            public int StaffID;
            public string FirstName;
            public string LastName;
            public string Username;
            public string Password;
            public string PIN;
            public UserRole Role;
            public string Email;
            public bool Active;
            public DateTime DateCreated;
            public int CustomersServed;

            public string FullName => $"{FirstName} {LastName}";
        }

        public static List<Staff> LoadStaff(string path)
        {
            var list = new List<Staff>();
            foreach (var f in ReadRows(path))
            {
                list.Add(new Staff
                {
                    StaffID = int.Parse(f[0]),
                    FirstName = f[1],
                    LastName = f[2],
                    Username = f[3],
                    Password = f[4],
                    PIN = f[5],
                    Role = (UserRole)int.Parse(f[6]),
                    Email = f[7],
                    Active = bool.Parse(f[8]),
                    DateCreated = DateTime.Parse(f[9], CultureInfo.InvariantCulture),
                    CustomersServed = int.Parse(f[10]),
                });
            }
            return list;
        }

        public static Staff FindByPin(string path, string pin)
        {
            return LoadStaff(path).FirstOrDefault(s => s.Active && s.PIN == pin);
        }

        public static Staff FindByLogin(string path, string username, string password)
        {
            return LoadStaff(path).FirstOrDefault(s =>
                s.Active && s.Username == username && s.Password == password);
        }

        // incrementing and adding customer served when Staff puts in their ID
        public static void IncrementCustomersServed(string path, int staffId)
        {
            string[] lines = File.ReadAllLines(path);
            for (int i = 1; i < lines.Length; i++)
            {
                var parts = lines[i].Split(',');
                if (int.Parse(parts[0]) == staffId)
                {
                    int current = int.Parse(parts[10]);
                    parts[10] = (current + 1).ToString();
                    lines[i] = string.Join(",", parts);
                    break;
                }
            }
            File.WriteAllLines(path, lines);
        }

        // product
        public class Product
        {
            public int ProductID;
            public string ProductName;
            public int CategoryID;
            public string Description;
            public decimal BasePrice;
            public string Brand;
            public string ImagePath;
            public bool Active;
            public DateTime DateAdded;
        }

        public static List<Product> LoadProducts(string path)
        {
            var list = new List<Product>();
            foreach (var f in ReadRows(path))
            {
                list.Add(new Product
                {
                    ProductID = int.Parse(f[0]),
                    ProductName = f[1],
                    CategoryID = int.Parse(f[2]),
                    Description = f[3],
                    BasePrice = decimal.Parse(f[4], CultureInfo.InvariantCulture),
                    Brand = f[5],
                    ImagePath = f[6],
                    Active = bool.Parse(f[7]),
                    DateAdded = DateTime.Parse(f[8], CultureInfo.InvariantCulture),
                });
            }
            return list;
        }

        // variant
        public class Variant
        {
            public int VariantID;
            public int ProductID;
            public string Size;
            public string Color;
            public string SKU;
            public int StockLevel;
            public int ReorderLevel;

            public bool IsOutOfStock => StockLevel <= 0;
            public bool IsLowStock => StockLevel > 0 && StockLevel <= ReorderLevel;
        }

        public static List<Variant> LoadVariants(string path)
        {
            var list = new List<Variant>();
            foreach (var f in ReadRows(path))
            {
                list.Add(new Variant
                {
                    VariantID = int.Parse(f[0]),
                    ProductID = int.Parse(f[1]),
                    Size = f[2],
                    Color = f[3],
                    SKU = f[4],
                    StockLevel = int.Parse(f[5]),
                    ReorderLevel = int.Parse(f[6]),
                });
            }
            return list;
        }

        // order
        public class Order
        {
            public int OrderID;
            public DateTime OrderDate;
            public int StaffID;
            public string CustomerName;
            public decimal Subtotal;
            public string DiscountCode;
            public decimal DiscountAmount;
            public decimal TaxAmount;
            public decimal Total;
            public string PaymentMethod;
            public string Status;
        }

        public static List<Order> LoadOrders(string path)
        {
            var list = new List<Order>();
            foreach (var f in ReadRows(path))
            {
                list.Add(new Order
                {
                    OrderID = int.Parse(f[0]),
                    OrderDate = DateTime.Parse(f[1], CultureInfo.InvariantCulture),
                    StaffID = int.Parse(f[2]),
                    CustomerName = f[3],
                    Subtotal = decimal.Parse(f[4], CultureInfo.InvariantCulture),
                    DiscountCode = f[5],
                    DiscountAmount = decimal.Parse(f[6], CultureInfo.InvariantCulture),
                    TaxAmount = decimal.Parse(f[7], CultureInfo.InvariantCulture),
                    Total = decimal.Parse(f[8], CultureInfo.InvariantCulture),
                    PaymentMethod = f[9],
                    Status = f[10],
                });
            }
            return list;
        }

        
        public static int AppendOrder(string path, Order order)
        {
            // get next order ID by finding max existing
            int nextId = 1001;
            if (File.Exists(path))
            {
                var existing = LoadOrders(path);
                if (existing.Count > 0)
                {
                    nextId = existing.Max(o => o.OrderID) + 1;
                }
            }

            order.OrderID = nextId;

            string line = string.Join(",", new[]
            {
                order.OrderID.ToString(),
                order.OrderDate.ToString("yyyy-MM-dd HH:mm:ss"),
                order.StaffID.ToString(),
                order.CustomerName,
                order.Subtotal.ToString("F2", CultureInfo.InvariantCulture),
                order.DiscountCode ?? "",
                order.DiscountAmount.ToString("F2", CultureInfo.InvariantCulture),
                order.TaxAmount.ToString("F2", CultureInfo.InvariantCulture),
                order.Total.ToString("F2", CultureInfo.InvariantCulture),
                order.PaymentMethod,
                order.Status,
            });

            File.AppendAllLines(path, new[] { line });
            return nextId;
        }

        // order item
        public class OrderItem
        {
            public int OrderItemID;
            public int OrderID;
            public int VariantID;
            public string ProductName;
            public string Size;
            public int Quantity;
            public decimal UnitPrice;
            public decimal LineTotal;
        }

        public static List<OrderItem> LoadOrderItems(string path)
        {
            var list = new List<OrderItem>();
            foreach (var f in ReadRows(path))
            {
                list.Add(new OrderItem
                {
                    OrderItemID = int.Parse(f[0]),
                    OrderID = int.Parse(f[1]),
                    VariantID = int.Parse(f[2]),
                    ProductName = f[3],
                    Size = f[4],
                    Quantity = int.Parse(f[5]),
                    UnitPrice = decimal.Parse(f[6], CultureInfo.InvariantCulture),
                    LineTotal = decimal.Parse(f[7], CultureInfo.InvariantCulture),
                });
            }
            return list;
        }

        public static void AppendOrderItems(string path, List<OrderItem> items)
        {
            int nextId = 1;
            if (File.Exists(path))
            {
                var existing = LoadOrderItems(path);
                if (existing.Count > 0)
                {
                    nextId = existing.Max(i => i.OrderItemID) + 1;
                }
            }

            var lines = new List<string>();
            foreach (var item in items)
            {
                item.OrderItemID = nextId++;
                lines.Add(string.Join(",", new[]
                {
                    item.OrderItemID.ToString(),
                    item.OrderID.ToString(),
                    item.VariantID.ToString(),
                    item.ProductName,
                    item.Size,
                    item.Quantity.ToString(),
                    item.UnitPrice.ToString("F2", CultureInfo.InvariantCulture),
                    item.LineTotal.ToString("F2", CultureInfo.InvariantCulture),
                }));
            }

            File.AppendAllLines(path, lines);
        }
    }
}