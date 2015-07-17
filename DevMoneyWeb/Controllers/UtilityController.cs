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

        // GET: Home
        public ActionResult Add()
        {
            UtilityManager mgr = new UtilityManager(_repository);
            CaptureUtilityViewModel view = new CaptureUtilityViewModel();
            return this.View(view);
        }
    }
}