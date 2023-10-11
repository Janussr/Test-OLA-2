Feature: IsStrike

A short summary of the feature

@Strike
Scenario: The player gets one strike
    Given a new bowling game
    When the player rolls the ball and hits 10 pins
    And the player then rolls the ball twice and hits 3 pins and 4 pins
    Then the score should be 24
