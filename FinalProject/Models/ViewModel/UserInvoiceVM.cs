using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalProject.Models.ViewModel
{
    public class UserInvoiceVM
    {
        public int InvoiceId { get; set; }

        [Display(Name = "User Name")]
        public string Name { get; set; }

        [Display(Name = "Bill")]
        public int? Bill { get; set; }

        [Display(Name = "Payment")]
        public string Payment { get; set; }

        [Display(Name = "Invoice Date")]
        [DataType(DataType.Date)]
        public DateTime? InvoiceDate { get; set; }

        [Display(Name = "Delivery Charge")]
        public decimal? DeliveryCharge { get; set; }

        [Display(Name = "Total Bill")]
        [Required(ErrorMessage = "Total Bill is required")]
        public decimal TotalBill { get; set; }
    }
}