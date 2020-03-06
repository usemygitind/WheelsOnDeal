using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WheelsOnDeal.Web.Areas.Dealer.Controllers
{
    public class HomeController : Controller
    {
        // GET: Dealer/Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Crm()
        {
            return View();
        }
    }
}