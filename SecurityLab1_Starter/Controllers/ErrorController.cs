using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecurityLab1_Starter.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NotFound(string aspxerrorpath)
        {
            ViewBag.ErrorUrl = aspxerrorpath;
            return View();
        }

        public ActionResult Internal()
        {
            return View();
        }
    }
}