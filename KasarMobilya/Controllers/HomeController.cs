using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KasarMobilya.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Response.Cookies["CacheLang"].Value = "tr_TR";
            return View();
        }

        public ActionResult About()
        {
            
            Response.Cookies["CacheLang"].Value = "tr_TR";
            return View();
        }

        public ActionResult Contact()
        {
            Response.Cookies["CacheLang"].Value = "tr_TR";
            return View();
        }
        public ActionResult References()
        {
            Response.Cookies["CacheLang"].Value = "tr_TR";
            return View();
        }

    }
}