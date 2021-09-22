Feature: DemoBadScenarioOutline
	These tests demonstrate how awesome Specflow is.

Background:
	Given I visit 'https://demoqa.com/links'

Scenario: Test Link Created
	When I click link Created
	Then There should be a response
	Then The response code should be 201
	Then The response text should be Created

Scenario: Test Link No Content
	When I click link No Content
	Then There should be a response
	Then The response code should be 204
	Then The response text should be No Content

Scenario: Test Link Moved
	When I click link Moved
	Then There should be a response
	Then The response code should be 301
	Then The response text should be Moved Permanently

Scenario: Test Link Bad Request
	When I click link Bad Request
	Then There should be a response
	Then The response code should be 400
	Then The response text should be Bad Request

Scenario: Test Link Unauthorized
	When I click link Unauthorized
	Then There should be a response
	Then The response code should be 401
	Then The response text should be Unauthorized

Scenario: Test Link Forbidden
	When I click link Forbidden
	Then There should be a response
	Then The response code should be 403
	Then The response text should be Forbidden

Scenario: Test Link Not Found
	When I click link Not Found
	Then There should be a response
	Then The response code should be 404
	Then The response text should be Not Found