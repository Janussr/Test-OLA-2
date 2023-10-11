using OLATwoBDDTest.Bowling;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowTest.StepDefinitions
{
    [Binding]
    public class BowlingStrikeStep
    {
        private readonly Game _bowlingGame = new();
        private int _result;

        [Given(@"a new bowling game")]
        public void GivenANewBowlingGame()
        {
            _bowlingGame.Score().Should().Be(0);
        }

        [When(@"the player rolls the ball and hits (.*) pins")]
        public void WhenThePlayerRollsTheBallAndHitsPins(int p10)
        {
            _bowlingGame.Roll(p10);
        }

        [When(@"the player then rolls the ball twice and hits (.*) pins and (.*) pins")]
        public void WhenThePlayerThenRollsTheBallTwiceAndHitsPinsAndPins(int p3, int p4)
        {
            _bowlingGame.Roll(p3);
            _bowlingGame.Roll(p4);
            _result = _bowlingGame.Score();
        }


        [Then(@"the score should be (.*)")]
        public void ThenTheScoreShouldBe(int s24)
        {
            _result.Should().Be(s24);
        }
    }
}
