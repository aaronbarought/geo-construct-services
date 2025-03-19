using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
// Done by Smit (Global.asax)
namespace WebApplication1
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Application["accessrequest"] = 0;
            Application["ApplicationStartTime"] = DateTime.Now.ToString();
        }

        void Application_BeginRequest(object sender, EventArgs e)
        {
            Application.Lock();
            Application["accessrequest"] = (int)Application["accessrequest"] + 1;
            Application.UnLock();
        }
        void Application_End(object sender, EventArgs e)
        {
            
            Application.Lock();
            Application["accessrequest"] = (int)Application["accessrequest"] - 1;
            Application.UnLock();
        }
    }
}