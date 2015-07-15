using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMoney
{
    public class UtilityInvoice
    {
        public int Id { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string UtilityName { get; set; }
        public string Comment { get; set; }
        public DateTime DueDate { get; set; }
        public decimal Amount { get; set; }
        public bool Paid { get; set; }
        public bool Overdue { get; set; }
        public UtilityType Type { get; set; }

        public enum UtilityType
        {
            Power,
            Water,
            Phone
        }    
    }


}
