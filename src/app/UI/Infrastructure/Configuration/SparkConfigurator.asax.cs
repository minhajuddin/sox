using System.Web.Mvc;
using Spark;
using Spark.Web.Mvc;

namespace Sox.UI.Infrastructure.Configuration {
    internal class SparkConfigurator {
        public static void Configure(ViewEngineCollection viewEngines) {
            var settings = new SparkSettings()
                .AddNamespace("System")
                .AddNamespace("System.Collections.Generic")
                .AddNamespace("System.Web.Mvc")
                .AddNamespace("System.Web.Mvc.Html")
                .AddNamespace("Sox.UI")
                .AddNamespace("Sox.UI.Infrastructure")
                .SetPageBaseType("ApplicationViewPage")
                .SetAutomaticEncoding(true);

            settings.SetDebug(true);
            var viewFactory = new SparkViewFactory(settings);
            viewEngines.Add(viewFactory);
        }
    }
}