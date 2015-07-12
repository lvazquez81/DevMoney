using DevMoney;
using DevMoneyWeb.Models;
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
            HomeViewModel view = new HomeViewModel();
            view.ExpenseHistory = mgr.GetExpenseHistory();
            return View("Index", view);
        }

        public ActionResult Remove(int expenseId)
        {
            ExpenseManager mgr = new ExpenseManager(_repository);
            mgr.Remove(expenseId);
            
            HomeViewModel view = new HomeViewModel();
            view.ExpenseHistory = mgr.GetExpenseHistory();
            return View("Index", view);            
        }

        [HttpPost]
        public ActionResult Add(HomeViewModel view)
        {
            if (ModelState.IsValid)
            {
                ExpenseManager mgr = new ExpenseManager(_repository);
                mgr.AddExpense(view.Amount.Value, view.Description);
                ModelState.Clear();
                view.ExpenseHistory = mgr.GetExpenseHistory();
            }

            return this.RedirectToAction("Index");
        }
    }
}