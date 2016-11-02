using FluentValidation;
using ServiceStack;
using Vatic.Core.Calculate;

namespace Vatic.Interface.Services
{
    public class CalculateService : Service
    {
        private readonly AbstractValidator<CalculateRequest> _vaildator;
        public CalculateService(AbstractValidator<CalculateRequest> vaildator)
        {
            _vaildator = vaildator;
        }
        public object Post(CalculateRequest request)
        {
            return new CalculateController(_vaildator).Calculate(request);
        }
    }
}