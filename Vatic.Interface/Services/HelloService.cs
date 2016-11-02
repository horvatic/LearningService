using ServiceStack;
using Vatic.Core.SayHello;

namespace Vatic.Interface.Services
{
    public class HelloService: Service
    {

        public object Get(HelloRequest request)
        {
            return new HelloController().Hello(request);
        }
    }
}