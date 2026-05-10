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
        // skips header row
        public static List<string[]> ReadRows(string path)
        {
            var rows = new List<string[]>();
            string[] lines = File.ReadAllLines(path);

            // skip header (index 0)
            for (int i = 1; i < lines.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lines[i])) continue;
                rows.Add(lines[i].Split(','));
            }
            return rows;
        }

        // staff lookups 

        public class Staff
        {
            public Guid StaffID;
            public string FirstName;
            public string LastName;
            public string Username;
            public string Password;
            public string PIN;
            public UserRole Role;          // changed from string
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
                    Role = (UserRole)int.Parse(f[6]),   // cast int -> enum
                    Email = f[7],
                    Active = bool.Parse(f[8]),
                    DateCreated = DateTime.Parse(f[9], CultureInfo.InvariantCulture),
                    CustomersServed = int.Parse(f[10]),
                });
            }
            return list;
        }

        // find by pin
        public static Staff FindByPin(string path, string pin)
        {
            return LoadStaff(path).FirstOrDefault(s => s.Active && s.PIN == pin);
        }

        // find by log in
        public static Staff FindByLogin(string path, string username, string password)
        {
            return LoadStaff(path).FirstOrDefault(s =>
                s.Active && s.Username == username && s.Password == password);
        }

        // adds another customer to customer served panel
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

        public class Product
        {
            // ProductID,ProductName,CategoryID,Description,BasePrice,Brand,ImagePath,Active,DateAdded
            public Guid ProductID;
            public string ProductName;
            public Guid CategoryID;
            public string Description;
            public decimal BasePrice;
            public bool Active;
            public DateTime DateAdded;
        }

        public static List<Products> LoadProducts(string path)
        {
            var list = new List<Products>();
            foreach (var f in ReadRows(path))
            {
                list.Add(new Products
                {
                    ProductID = int.Parse(f[0]),
                    ProductName = f[1],
                    LastName = f[2],
                    Username = f[3],
                    Password = f[4],
                    PIN = f[5],
                    Role = (UserRole)int.Parse(f[6]),   // cast int -> enum
                    Email = f[7],
                    Active = bool.Parse(f[8]),
                    DateCreated = DateTime.Parse(f[9], CultureInfo.InvariantCulture),
                    CustomersServed = int.Parse(f[10]),
                });
            }
            return list;
        }
    }
}