Feature: DemoContext
	These tests show how custom context works.

Scenario: Demo Context
	Given I visit 'https://demoqa.com/automation-practice-form'
	When I type 'Petko' as student's first name
		And I type 'Zhekov' as student's last name
		And I type 'petko.zhekov@ascentsoftware.eu' as student's email
		And I select male gender
		And I type '1234567890' as student's phone
		And I type '08 Mar 1988' as student's date of birth
		And I submit the student's form
	Then The results should be displayed
		And Student's full name should be correct
		And Student's email should be correct
		And Student's gender should be correct
		And Student's phone should be correct
		And Student's date of birth should be correct