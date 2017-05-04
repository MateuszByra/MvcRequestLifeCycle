using MvcRequestLifeCycle.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MvcRequestLifeCycle
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            ControllerBuilder.Current.SetControllerFactory(new ParameterControllerFactory());

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ViewEngines.Engines.Insert(0,new ThemeViewEngine());
        }

        protected void Application_BeginRequest()
        {
            Debug.WriteLine("Begin Request");
        }

        protected void Application_MapRequestHandler()
        {
            Debug.WriteLine("Map Handler");
        }

        protected void Application_PostMapRequestHandler()
        {
            Debug.WriteLine("Post Map Handler");
        }

        protected void Application_AcquireRequestState()
        {
            Debug.WriteLine("Request state");
        }

        protected void Application_PreRequestHandlerExecute()
        {
            Debug.WriteLine("Pre Handler Execute");
        }

        protected void Application_PostRequestHandlerExecute()
        {
            Debug.WriteLine("Post Handler Execute");
        }

        protected void Application_EndRequest()
        {
            Debug.WriteLine("EndRequest");
        }
    }
}
