using Gherkin;
using OLATwoBDDTest;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowReverseString.StepDefinitions
{
    [Binding]
    public class StringLowercaseStepDefinitions
    {

        private readonly StringUtilityBDD _stringUtil = new();
        private string _result;

        [Given(@"I have a string ""([^""]*)""")]
        public void GivenIHaveAString(string ABC)
        {
            _stringUtil.aBc = ABC;
        }

        [When(@"I convert the string to lowercase")]
        public void WhenIConvertTheStringToLowercase()
        {
            _result = _stringUtil.LowerCase();
        }

        [Then(@"the string should be lowercase ""([^""]*)""")]
        public void ThenTheStringShouldBeLowercase(string abc)
        {
            _result.Should().Be(abc);
        }
    }
}
