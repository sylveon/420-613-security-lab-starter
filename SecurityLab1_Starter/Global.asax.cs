using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SecurityLab1_Starter
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private EventLog log = new EventLog("Application")
        {
            Source = "Application"
        };

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_Error()
        {
            if (log != null)
            {
                var ex = Server.GetLastError();
                log.WriteEntry(ex.ToString(), EventLogEntryType.Error);
            }

            // redirect to the right error page seems to happen implicitly for me
        }

        public override void Dispose()
        {
            log.Dispose();
            log = null;

            base.Dispose();
        }
    }
}
