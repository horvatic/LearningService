using Vatic.Core.SayHello;
using Xunit;

namespace Vatic.Test.SayHello
{

    public class HelloControllerTest
    {
        [Theory]
        [InlineData("Shawn")]
        [InlineData("809")]
        [InlineData("")]
        [InlineData(null)]
        public void Return_Hello_With_Name(string name)
        {
            var controller = BuildController();
            var request = new HelloRequest() { Name = name };

            var result = controller.Hello(request);

            Assert.Equal($"Hello, {name}", result.Result);
        }

        private HelloController BuildController()
        {
            return new HelloController();
        }
    }
}