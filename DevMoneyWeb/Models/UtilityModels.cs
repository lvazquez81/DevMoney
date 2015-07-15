using DevMoney;
using System;
using System.Collections.Generic;
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
        public UtilityInvoice.UtilityType Type { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string Comment { get; set; }
        public DateTime DueDate { get; set; }
    }
}