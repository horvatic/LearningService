using System;
using FluentValidation;

namespace Vatic.Core.Calculate
{
    public class CalculateController
    {
        private readonly AbstractValidator<CalculateRequest> _vaildator;

        public CalculateController(AbstractValidator<CalculateRequest> vaildator)
        {
            _vaildator = vaildator;
        }
        public CalculateResponce Calculate(CalculateRequest request)
        {
            if (!_vaildator.Validate(request).IsValid) throw new Exception("Invaild Request");
            switch (request.Operation)
            {
                case "+":
                    return new CalculateResponce {Result = request.ValueOne + request.ValueTwo};
                case "-":
                    return new CalculateResponce {Result = request.ValueOne - request.ValueTwo};
                case "*":
                    return new CalculateResponce { Result = request.ValueOne * request.ValueTwo };
                case "/":
                    return new CalculateResponce { Result = request.ValueOne / request.ValueTwo };
                default:
                    throw new Exception("Not A Supported Format");
            }
        }
    }
}
