using System.Web.Mvc;
using System.Web.Routing;
using Sox.UI.Infrastructure.Configuration;

namespace Sox.UI {
    public class SoxMvcApplication : System.Web.HttpApplication {
        protected void Application_Start() {
            AreaRegistration.RegisterAllAreas();
            RouteConfigurator.Configure(RouteTable.Routes);//register routes
            SparkConfigurator.Configure(ViewEngines.Engines);
        }
    }
}