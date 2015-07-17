using DevMoney;
using DevMoneyWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevMoneyWeb.Controllers
{
    public class UtilityController : Controller
    {
        private readonly IUtilityRepository _repository;
        public UtilityController()
        {
            _repository = new InMemoryUtilityRepository();
        }

        // GET: Home
        public ActionResult Index()
        {
            UtilityManager mgr = new UtilityManager(_repository);
            ListUtilityViewModel view = new ListUtilityViewModel();
            view.Invoices = mgr.GetUtilityInvoices();
            return this.View("Index", view);
        }

        [HttpGet]
        public ActionResult Add()
        {
            UtilityManager mgr = new UtilityManager(_repository);
            CaptureUtilityViewModel view = new CaptureUtilityViewModel();
            view.InvoiceDate = DateTime.Today;
            view.DueDate = DateTime.Today;
            return this.View(view);
        }

        [HttpPost]
        public ActionResult Add(CaptureUtilityViewModel view)
        {
            if (this.ModelState.IsValid)
            {
                UtilityManager mgr = new UtilityManager(_repository);
                mgr.AddUtility(view.Amount, view.InvoiceDate, view.Type);
            }

            return this.RedirectToAction("Index");
        }

        public ActionResult Remove(int invoiceId)
        {
            UtilityManager mgr = new UtilityManager(_repository);
            mgr.Remove(invoiceId);

            ListUtilityViewModel view = new ListUtilityViewModel();
            view.Invoices = mgr.GetUtilityInvoices();
            return this.View("Index", view);
        }
    }
}