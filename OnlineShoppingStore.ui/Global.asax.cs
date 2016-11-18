using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;


namespace OnlineShoppingStore.ui
{
    public class MvcApplication : System.Web.HttpApplication
    {

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        protected void Application_End()
        {
            Debug.WriteLine("App ends");
        }

        protected void Application_PreRequestHandlerExecute()
        {
            Debug.WriteLine("App pre request handler");
        }

        protected void Application_AcquireRequestState()
        {
            Debug.WriteLine("App acquire request state");
        }

        protected void Application_BeginRequest()
        {
            Debug.WriteLine("app begin request");
        }

        protected void Application_MapRequestHandler()
        {
            Debug.WriteLine("App map request handler");
        }
    }

    public class LogModule : IHttpModule
    {
        public void Dispose()
        {
            Console.WriteLine("hehe");
        }

        public void Init(HttpApplication context)
        {
            Console.WriteLine("haha");
        }
    }
}
