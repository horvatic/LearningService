using FluentValidation;

namespace Vatic.Core.Calculate
{
    public class CalculateVaildator : AbstractValidator<CalculateRequest>
    {
        public CalculateVaildator()
        {
            RuleFor(req => req.ValueOne).NotNull();
            RuleFor(req => req.ValueTwo).NotNull();
            RuleFor(req => req.Operation).NotNull();
        }
    }
}
