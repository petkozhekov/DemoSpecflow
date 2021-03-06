Feature: Demo
	These tests demonstrate how awesome Specflow is.

Scenario: Basic Demo
	Given I visit 'https://demoqa.com/text-box'
	When I type 'Petko Zhekov' as my user name
		And I type 'Petko.Zhekov@ascentsoftware.eu' as my email
		And I enter 'ul.Samokov #28i' as my current address
		And I put 'Sofia' as my permanent address
		And I submit the form
	Then The output should be
		| Name         | Email                          | Current Address | Permananet Address |
		| Petko Zhekov | Petko.Zhekov@ascentsoftware.eu | ul.Samokov #28i | Sofia              |