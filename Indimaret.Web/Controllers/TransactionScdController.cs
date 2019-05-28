using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Indimaret.Web.Controllers
{
    public class TransactionScdController : Controller
    {
        // GET: TransactionScd
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DaftarBarang()
        {
            return PartialView();
        }
    }
}