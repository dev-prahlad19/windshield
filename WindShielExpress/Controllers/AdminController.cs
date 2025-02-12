using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WindShielExpress.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        #region Masters
        public ActionResult BrandMaster()
        {
            return View();
        }
        public ActionResult ProductMaster()
        {
            return View();
        }

        public ActionResult InvoiceTypeMaster()
        {
            return View();
        }
        #endregion


        #region  Transactions
        public ActionResult AddCustomer()
        {
            return View();
        }

        public ActionResult UserManagement()
        {
            return View();
        }
        public ActionResult EstimateInvoice()
        {
            return View();
        }
        #endregion


    }
}