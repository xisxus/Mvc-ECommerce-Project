using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Models.ViewModel
{
    public class OrderUserVM
    {

        public int InvoiceId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public Nullable<int> Bill { get; set; }
        public string Payment { get; set; }
        public DateTime InvoiceDate { get; set; }
        public Nullable<byte> Status { get; set; }
        public Nullable<decimal> DeliveryCharge { get; set; }
        public decimal TotalBill { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public int Unit { get; set; }
        public int Qty { get; set; }
        public int Total { get; set; }
        public DateTime OrderDate { get; set; }
        public string Email  { get; set; }

        public virtual Product Product { get; set; }

    }
}