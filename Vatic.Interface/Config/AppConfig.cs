using System.Reflection;
using FluentValidation;
using ServiceStack;
using Vatic.Core.Calculate;
using Vatic.Core.SayHello;
using Vatic.Interface.Routes;

namespace Vatic.Interface.Config
{
    public class AppConfig : AppHostBase
    {
        public AppConfig() : base("Web Services", Assembly.GetExecutingAssembly())
        {

        }

        public override void Configure(Funq.Container container)
        {
            container.RegisterAutoWiredAs<CalculateVaildator, AbstractValidator<CalculateRequest>>();
            Router.SetRoutes(this);
        }
    }
}