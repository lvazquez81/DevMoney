using DevMoney;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DevMoneyWeb.Models
{
    public class HomeViewModel
    {
        [Display(Name = "expense amount")]
        [Required(ErrorMessage = "Please specify expense amount.")]
        [DataType(DataType.Currency)]
        public decimal? Amount { get; set; }

        [Display(Name = "expense description")]
        [StringLength(10)]
        public string Description { get; set; }
        public IList<ExpenseDetail> ExpenseHistory { get; set; }
    }
}