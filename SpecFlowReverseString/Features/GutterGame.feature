Feature: GutterGame

A short summary of the feature

@GutterGame
Scenario: Gutter Game
	Given yet another new bowling game
	When the player rolls 20 times and hits 0 pins each time
	Then the final game score should be 0
