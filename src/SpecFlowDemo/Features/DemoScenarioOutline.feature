Feature: DemoScenarioOutline
	These tests demonstrate how awesome Specflow is.

Background:
	Given I visit 'https://demoqa.com/links'

Scenario Outline: Test Links
	When I click link <Link>
	Then There should be a response
	Then The response code should be <Code>
	Then The response text should be <Text>
Examples: 
	| Link         | Code | Text              |
	| Created      | 201  | Created           |
	| No Content   | 204  | No Content        |
	| Moved        | 301  | Moved Permanently |
	| Bad Request  | 400  | Bad Request       |
	| Unauthorized | 401  | Unauthorized      |
	| Forbidden    | 403  | Forbidden         |
	| Not Found    | 404  | Not Found         |
