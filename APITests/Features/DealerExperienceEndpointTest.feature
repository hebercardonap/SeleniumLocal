Feature: DealerExperienceEndpointTest
	To verify the new DEX endpoint implementation

@DEX API Test
Scenario: Error 404 returned when 2021 is passed
	Given I have DEX endpoint with year 2019 and dealer 02040900
	And I have base URL
	When I call GET method
	Then API response is as expected
