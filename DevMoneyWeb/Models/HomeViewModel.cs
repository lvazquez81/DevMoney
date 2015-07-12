using DevMoney;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevMoneyWeb.Models
{
    public class HomeViewModel
    {
        public ExpenseDetail NewExpense { get; set; }
        public IList<ExpenseDetail> ExpenseHistory { get; set; }
    }
}