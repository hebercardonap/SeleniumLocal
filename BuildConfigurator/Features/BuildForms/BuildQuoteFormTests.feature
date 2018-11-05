Feature: BuildQuoteFormTests
	To verify that form fields validations are
	working as expected

@FormValidation
Scenario: Verify First name validation error is displayed
	Given I have navigated to build quote page
	When I get to build quote page
	And I enter last name lastName
	And I enter email test@polaris.com
	And I enter phone number 2067243787
	And I enter postal code 98008
	And I click Age checkbox
	And I click getinternetprice button
	Then first name validation error is displayed

@FormValidation
Scenario: Verify last name validation error is displayed
	Given I have navigated to build quote page
	When I get to build quote page
	And I enter first name firstName
	And I enter email test@polaris.com
	And I enter phone number 2067243787
	And I enter postal code 98008
	And I click Age checkbox
	And I click getinternetprice button
	Then last name validation error is displayed

@FormValidation
Scenario: Verify email validation error is displayed
	Given I have navigated to build quote page
	When I get to build quote page
	And I enter first name firstName
	And I enter last name lastName
	And I enter phone number 2067243787
	And I enter postal code 98008
	And I click Age checkbox
	And I click getinternetprice button
	Then email validation error is displayed

@FormValidation
Scenario: Verify email invalid format validation error is displayed
	Given I have navigated to build quote page
	When I get to build quote page
	And I enter first name firstName
	And I enter last name lastName
	And I enter email test@
	And I enter phone number 2067243787
	And I enter postal code 98008
	And I click Age checkbox
	And I click getinternetprice button
	Then email validation error is displayed

@FormValidation
Scenario: Verify age checkbox validation error is displayed
	Given I have navigated to build quote page
	When I get to build quote page
	And I enter first name firstName
	And I enter last name lastName
	And I enter email test@polaris.com
	And I enter phone number 2067243787
	And I enter postal code 98008
	And I click getinternetprice button
	Then age checkbox validation error is displayed
