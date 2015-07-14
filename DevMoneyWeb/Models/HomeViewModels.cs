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
        [Display(Name = "Amount")]
        [Required(ErrorMessage = "Please specify expense amount.")]
        [DataType(DataType.Currency)]
        public decimal? Amount { get; set; }

        [Display(Name = "Description")]
        [StringLength(10)]
        public string Description { get; set; }
        

        [Display(Name = "Search")]
        public string Search { get; set; }
        public IList<ExpenseDetail> ExpenseHistory { get; set; }
    }

    public class SearchViewModel
    {
        [Display(Name = "Search")]
        public string SearchKey { get; set; }

        public IList<ExpenseDetail> SearchResults { get; set; }

        
    }
}