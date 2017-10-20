using api.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace tests
{
    public class TestHelloWorldController
    {
        [Fact]
        public void TestHelloResponseFromApi()
        {
            HelloWorldController controller = new HelloWorldController();
            var result = Assert.IsType<ObjectResult>(controller.Get());
        }
    }
}