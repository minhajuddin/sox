using System.Web.Mvc;
using System.Web.Routing;

namespace Sox.UI.Infrastructure.Configuration {
    internal static class RouteConfigurator {
        public static void Configure(RouteCollection routes) {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default",                                              // Route name
                "{controller}/{action}/{id}",                           // URL with parameters
                new { controller = "Home", action = "Index", id = "" }  // Parameter defaults
                );
        }
    }
}