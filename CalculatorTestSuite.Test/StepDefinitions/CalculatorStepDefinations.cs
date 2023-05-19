using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
using NUnit.Framework;

namespace CalculatorTestSuite.Test.StepDefinitions
{
    [Binding]
    internal class CalculatorStepDefinations
    {
        private Calculator.Calculator _calculator = new Calculator.Calculator();
        ScenarioContext _scenarioContext;
        public CalculatorStepDefinations(ScenarioContext context)
        {
            _scenarioContext = context;
        }

        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int num)
        {
            _scenarioContext["First"] = num;
        }

        [When(@"the second number is (.*)")]
        public void WhenTheSecondNumberIs(int num)
        {
            _scenarioContext["Second"] = num;
        }

        [Then(@"the sum of first and second should be (.*)")]
        public void ThenTheSumShouldBe(int num)
        {
            int result = _calculator.Add((int)_scenarioContext["First"], (int)_scenarioContext["Second"]);

            Assert.IsTrue(result == num);
        }

        [Then(@"the substraction of first and second should be (.*)")]
        public void ThenTheSubShouldBe(int num)
        {
            int result = _calculator.Substract((int)_scenarioContext["First"], (int)_scenarioContext["Second"]);

            Assert.IsTrue(result == num);
        }

        [Then(@"the multiplication of first and second should be (.*)")]
        public void ThenTheMulShouldBe(int num)
        {
            int result = _calculator.Multiply((int)_scenarioContext["First"], (int)_scenarioContext["Second"]);

            Assert.IsTrue(result == num);
        }


    }
}
