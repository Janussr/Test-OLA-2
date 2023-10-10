using OLATwoBDDTest;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowReverseString.StepDefinitions
{
    [Binding]
    public class StringCapitalizeStepDefinitions
    {
        private readonly StringUtilityBDD _stringUtil = new();
        private string _result;

        [Given(@"a lowercased text is ""([^""]*)""")]
        public void GivenAStringIs(string aBcd)
        {
            _stringUtil.aBc = aBcd;
        }
        [When(@"the text is capitalized")]
        public void WhenTheStringIsCapitalized()
        {
            _result = _stringUtil.Capitalize();
        }

        [Then(@"the text should capitalized like ""([^""]*)""")]
        public void ThenTheTextShouldCapitalizedLike(string ABCD)
        {
            _result.Should().Be(ABCD);
        }
    }
}
