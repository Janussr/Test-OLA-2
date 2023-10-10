Feature: StringCapitalize


@StringCapitalize
Scenario: Capitalize a string
Given a lowercased text is "[abcd]"
When the text is capitalized
Then the text should capitalized like "[ABCD]"
