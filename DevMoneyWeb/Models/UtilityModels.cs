using DevMoney;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DevMoneyWeb.Models
{
    public class ListUtilityViewModel
    {
        public decimal TotalAmount { get; set; }
        public IList<UtilityInvoice> Invoices { get; set; }
    }
    
    public class CaptureUtilityViewModel
    {
        public string UtilityName { get; set; }
        public string Comment { get; set; }
        
        [Required]
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }

        public decimal Amount { get; set; }
        public bool Paid { get; set; }
        public bool Overdue { get; set; }

        [Required]
        [Range(1, 3, ErrorMessage = "Select utility type")]
        public UtilityInvoice.UtilityType Type { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime InvoiceDate { get; set; }
    }
}