Feature: DealerExperienceEndpointTest
	To validate response codes on DEX endpoint
	for ORV



@DEX API Test
Scenario Outline: Error scenario invalid year
	Given I have DEX <Brand> endpoint with year <Year> and dealer <Dealer>
	When I call GET method
	Then API response code is <Response>
    Examples:
	| Brand | Year | Dealer   | Response |
	| RZR   | 2021 | 02040900 | 404      |
	| RAN   | 2021 | 02040900 | 404      |
	| GEN   | 2021 | 02040900 | 404      |
	| ATV   | 2021 | 02040900 | 404      |
	| ACE   | 2021 | 02040900 | 404      |
	| RZR   | 2017 | 02040900 | 404      |
	| RAN   | 2018 | 02040900 | 404      |
	| GEN   | 2018 | 02040900 | 404      |
	| ATV   | 2018 | 02040900 | 404      |
	| ACE   | 2018 | 02040900 | 404      |
	
@DEX API Test
Scenario Outline: Error scenario invalid year format
	Given I have DEX <Brand> endpoint with year <Year> and dealer <Dealer>
	When I call GET method
	Then API response code is <Response>
	Examples:
	| Brand | Year | Dealer   | Response |
	| RZR   | 202 | 02040900 | 404      |
	| RAN   | 202 | 02040900 | 404      |
	| GEN   | 202 | 02040900 | 404      |
	| ATV   | 202 | 02040900 | 404      |
	| ACE   | 202 | 02040900 | 404      |

@DEX API Test
Scenario Outline: Error scenario invalid dealer id
	Given I have DEX <Brand> endpoint with year <Year> and dealer <Dealer>
	When I call GET method
	Then API response code is <Response>
	Examples:
	| Brand | Year | Dealer | Response |
	| RZR   | 2019 | 123456 | 404      |
	| RAN   | 2019 | 123456 | 404      |
	| GEN   | 2019 | 123456 | 404      |
	| ATV   | 2019 | 123456 | 404      |
	| ACE   | 2019 | 123456 | 404      |

@DEX API Test
Scenario Outline: Success scenario valid year valid dealer id
	Given I have DEX <Brand> endpoint with year <Year> and dealer <Dealer>
	When I call GET method
	Then API response code is <Response>
	Examples:
	| Brand | Year | Dealer	  | Response |
	| RZR   | 2019 | 02040900 | 200      |
	| RAN   | 2019 | 02040900 | 200      |
	| GEN   | 2019 | 02040900 | 200      |
	| ATV   | 2019 | 02040900 | 200      |
	| ACE   | 2019 | 02040900 | 200      |

@DEX API Test
Scenario Outline: Success scenario validate response properties
	Given I have DEX <Brand> endpoint with year <Year> and dealer <Dealer>
	When I call GET method
	Then API response code is <Response>
	Examples:
	| Brand | Year | Dealer   | Response |
	| RZR   | 2019 | 02040900 | 200      |
	| RAN   | 2019 | 02040900 | 200      |
	| GEN   | 2019 | 02040900 | 200      |
	| ATV   | 2019 | 02040900 | 200      |
	| ACE   | 2019 | 02040900 | 200      |

