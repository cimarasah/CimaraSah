using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Parse;

namespace OnMuseum
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //this.InitializeComponent();
            //this.Suspending += OnSuspending;

            ParseClient.Initialize("pBkVHpn3Wx1q85WP0joKEt6XUyggfZsggukH3H0S", "KRZxRAbupYQgkKlCFJTIVk41UMZ0FnK1fte295L5");
            
        }
    }
}
