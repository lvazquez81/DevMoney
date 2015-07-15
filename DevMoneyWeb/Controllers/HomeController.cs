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
        private readonly IExpenseRepository _repository;
        public HomeController()
        {
            _repository = new InMemoryExpenseRepository();
        }

        // GET: Home
        public ActionResult Index()
        {
            ExpenseManager mgr = new ExpenseManager(_repository);
            HomeViewModel view = new HomeViewModel();
            view.ExpenseHistory = mgr.GetExpenseHistory();
            return this.View("Index", view);
        }

        public ActionResult Remove(int expenseId)
        {
            ExpenseManager mgr = new ExpenseManager(_repository);
            mgr.Remove(expenseId);

            HomeViewModel view = new HomeViewModel();
            view.ExpenseHistory = mgr.GetExpenseHistory();
            return this.View("Index", view);
        }

        [HttpPost]
        public ActionResult Add(HomeViewModel view)
        {
            if (this.ModelState.IsValid)
            {
                ExpenseManager mgr = new ExpenseManager(_repository);
                mgr.AddExpense(view.Amount.Value, view.Description);
                this.ModelState.Clear();
                view.ExpenseHistory = mgr.GetExpenseHistory();
            }

            return this.RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Search(HomeViewModel view)
        {
            ExpenseManager mgr = new ExpenseManager(_repository);
            this.ModelState.Clear();
            view.ExpenseHistory = mgr.Search(view.Search);
            return this.View("Index", view);
        }
    }
}