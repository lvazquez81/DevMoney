using DevMoney;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevMoneyWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository _repository;
        public HomeController()
        {
            _repository = new InMemoryRepository();
        }

        // GET: Home
        public ActionResult Index()
        {
            ExpenseManager mgr = new ExpenseManager(_repository);
            IList<ExpenseDetail> expenses = mgr.GetExpenseHistory();
            return View("Index", expenses);
        }

        public ActionResult Remove(int expenseId)
        {
            ExpenseManager mgr = new ExpenseManager(_repository);
            mgr.Remove(expenseId);
            IList<ExpenseDetail> expenses = mgr.GetExpenseHistory();
            return View("Index", expenses); // Return to same index
        }

        public ActionResult Add()
        {
            ExpenseManager mgr = new ExpenseManager(_repository);
            mgr.AddExpense(5, "abc");
            IList<ExpenseDetail> expenses = mgr.GetExpenseHistory();
            return View("Index", expenses); // Return to same index
        }
    }
}