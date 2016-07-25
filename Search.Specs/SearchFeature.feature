Feature: Search
	Verify the search funcationality

@mytag
Scenario: Verify search functionality
	Given I navigate to page "https://www.google.com"
	And Page is loaded
	When I enter search term in Search text box
	| term     |
	| SpecFlow |
	And I click on Search button
	Then Search items shows the items related to term
