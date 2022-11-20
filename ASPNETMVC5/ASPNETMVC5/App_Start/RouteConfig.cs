using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ASPNETMVC5
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Secundaria",
            //    url: "{controller}/{action}/{id}/{pesquisa}",
            //    defaults: new {
            //        controller = "Cliente", 
            //        action = "Pesquisa", 
            //        id = UrlParameter.Optional,
            //        pesquisa = UrlParameter.Optional
            //    }
            //);
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Clientes", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
