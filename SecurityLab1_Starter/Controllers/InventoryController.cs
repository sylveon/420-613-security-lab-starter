using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecurityLab1_Starter.Controllers
{
    public class InventoryController : Controller
    {
        // GET: Inventory
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Error()
        {
            throw new Exception();
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            filterContext.ExceptionHandled = true;

            using (var writer = new StreamWriter(@"T:\Projects\420-613-security-lab-starter\SecurityLab1_Starter\log.txt", true))
            {
                writer.WriteLine(filterContext.Exception.ToString());
            }

            filterContext.Result = RedirectToAction("Internal", "Error");
        }
    }
}