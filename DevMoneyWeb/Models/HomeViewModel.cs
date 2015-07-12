using DevMoney;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevMoneyWeb.Models
{
    public class HomeViewModel
    {
        public decimal? Amount { get; set; }
        public string Description { get; set; }
        public IList<ExpenseDetail> ExpenseHistory { get; set; }
    }
}