namespace Vatic.Core.SayHello
{
    public class HelloController
    {
        public HelloResponse Hello(HelloRequest request)
        {
            return new HelloResponse { Result = "Hello, " + request.Name };
        }
    }
}
