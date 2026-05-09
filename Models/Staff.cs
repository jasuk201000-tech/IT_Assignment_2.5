using IT_Assessment_2.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Assessment_2.Models
{
    public class Staff
    {
        // enumerates staff role for easier implementation later on - will be implemented in csv file as an integer for easier parsing
        public enum UserRole
            {
            Admin = 1,
            Manager = 2,
            Cashier = 3
            }

        // properties of the staff class

        public int StaffId { get; set; }
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        // computer property
        public string Username => $"{FirstName} {LastName}";

        public int CustomersServed { get; set; }

        public string Email { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public int PIN { get; set; }

        public UserRole Role { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime LastActive { get; set; } = DateTime.Now;

        public static implicit operator Staff(CsvHelper.Staff v)
        {
            throw new NotImplementedException();
        }
    }
}
