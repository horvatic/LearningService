using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vatic.Core.Calculate;
using Xunit;

namespace Vatic.Test.Calculate
{
    public class CalculateControllerTest
    {
        [Theory]
        [InlineData(1,2,"+",3)]
        [InlineData(3,4,"-",-1)]
        [InlineData(2, 4, "*", 8)]
        [InlineData(8, 2, "/", 4)]
        public void Calculate_Value(double valueOne, double valueTwo, string operation, double expected)
        {
            var request = new CalculateRequest {ValueOne = valueOne, ValueTwo = valueTwo, Operation = operation };
            var controller = BuildController();

            var responce = controller.Calculate(request);

            Assert.Equal(expected, responce.Result);
        }

        private CalculateController BuildController()
        {
            return new CalculateController(new CalculateVaildator());
        }
    }
}
