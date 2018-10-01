Feature: DealerExperienceEndpointTest
	To verify the new DEX endpoint implementation

@DEX API Test
Scenario: Error scenario invalid year
	Given I have DEX RZR endpoint with year 2021 and dealer 02040900
	When I call GET method
	Then API response code is 404

@DEX API Test
Scenario: Error scenario invalid year format
	Given I have DEX RZR endpoint with year 202 and dealer 02040900
	When I call GET method
	Then API response code is 404

@DEX API Test
Scenario: Error scenario invalid dealer id
	Given I have DEX RZR endpoint with year 2019 and dealer 12345689
	When I call GET method
	Then API response code is 404

@DEX API Test
Scenario: Success scenario valid year valid dealer id
	Given I have DEX RZR endpoint with year 2019 and dealer 02040900
	When I call GET method
	Then API response code is 200

@DEX API Test
Scenario: Success scenario validate response properties
	Given I have DEX RZR endpoint with year 2019 and dealer 02040900
	When I call GET method
	And API response code is 200
	Then Response property values are as expected

