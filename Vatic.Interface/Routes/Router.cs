using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack;
using Vatic.Core.Calculate;
using Vatic.Core.SayHello;

namespace Vatic.Interface.Routes
{
    public class Router
    {
        public static void SetRoutes(AppHostBase host)
        {
            host.Routes
                .Add<HelloRequest>("/hello", "GET")
                .Add<HelloRequest>("/hello/{Name}", "GET")
                .Add<CalculateRequest>("/calculate", "POST");
        }
    }
}