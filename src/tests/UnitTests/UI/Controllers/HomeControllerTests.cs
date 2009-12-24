using System.Web.Mvc;
using Sox.UI.Controllers;
using Xunit;
using MvcContrib.TestHelper;


namespace Sox.UnitTests.UI.Controllers {
    public class HomeControllerTests : ControllerTestBase {

        [Fact]
        public void IndexActionReturnsTheIndexView() {
            var controller = new HomeController();
            var result = controller.Index() as ViewResult;
            Assert.NotNull(result);
            result.ForView("");
        }
    }
}