Feature: Feature1

A short summary of the feature

@Spare
Scenario: Spare
	Given another new bowling game
	When the player rolls the balls twice and hits 5 pins each time
	And the player then rolls the ball once and hits 3 pins
	Then the final score should be 16
