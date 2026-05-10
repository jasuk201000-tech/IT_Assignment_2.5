using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Assessment_2.Models
{
    public class Orders
    {
        // enumerated payment methods
        public enum PaymentMethod
        {
            Card = 1,
            Cash = 2,
            Mixed = 3,
        }

        // enumerating status role
        public enum Status
        { 
            Pending = 1,
            Returned = 2,
            Finished = 3,
        }

        // to implement: OrderID,OrderDate,StaffID,CustomerName,Subtotal,DiscountCode,DiscountAmount,TaxAmount,Total,PaymentMethod,Status

        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;

        public int StaffID { get; set; }

        public string CustomerName { get; set; } = string.Empty;

        public decimal Subtotal { get; set; }

        public string DiscountCode { get; set; } = string.Empty;

        public decimal DiscountAmount { get; set; } 

        public decimal TaxAmount { get; set; }

        public decimal Total { get; set; }

    }
}
