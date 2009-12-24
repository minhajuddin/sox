using System.Web.Mvc;

namespace Sox.UI.Controllers {
    public class HomeController : ApplicationController {
        public ActionResult Index() {
            return View();
        }
    }
}