using IT_Assessment_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IT_Assignment_2.Models
{
    public enum OrderStatus
    {
        Pending = 1,
        Completed = 2,
        Refunded = 3,
        Voided = 4
    }

    public enum PaymentMethod
    {
        Cash = 1,
        Card = 2,
        Mixed = 3
    }

    public class Order
    {
        //identifying factors
        public int OrderId { get; set; }
        public int StaffId { get; set; }
        public string? CustomerName { get; set; }    // optional — walk-ins have no name

        //status and payment details
        public OrderStatus Status { get; set; } = OrderStatus.Pending;
        public PaymentMethod PaymentMethod { get; set; }

        //financial details
        public decimal DiscountAmount { get; set; }
        public string? DiscountCode { get; set; }
        public decimal TaxAmount { get; set; }

        public int Subtotal { get; set; }

        public decimal Total => Subtotal - DiscountAmount + TaxAmount;

    }
}