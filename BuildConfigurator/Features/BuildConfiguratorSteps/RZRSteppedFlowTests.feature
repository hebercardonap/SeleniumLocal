Feature: RZRSteppedFlowTests
	Verify that build configurator steps 
	can be performed for a particular brand

@Verify build stepped process
Scenario: Verify RZR build stepped process one seat
	Given I have navigated to RZR build model page
	When I select one seat option
	And I select random model
	And I select trim
	And I select random color
	And I click next button
	And I get to build page
	And I click Protection accessory category
	And I click Roofs accessory subcategory
	And I add random available accessory
	And I click finished button
	And I get to build quote page
	And I fill the form
	And I click getinternetprice button
	And I get to build confirmation page
	Then build confirmation page is as expected

@Verify build stepped process
Scenario: Verify RZR build stepped process two seat
	Given I have navigated to RZR build model page
	When I select two seat option
	And I select random model
	And I select trim
	And I select random color
	And I click next button
	And I get to build page
	And I click Protection accessory category
	And I click Windshields accessory subcategory
	And I add random available accessory
	And I click finished button
	And I get to build quote page
	And I fill the form
	And I click getinternetprice button
	And I get to build confirmation page
	Then build confirmation page is as expected

@Verify build stepped process
Scenario: Verify RZR build stepped process four seat
	Given I have navigated to RZR build model page
	When I select four seat option
	And I select random model
	And I select trim
	And I select random color
	And I click next button
	And I get to build page
	And I add widshield accessory
	And I click finished button
	And I get to build quote page
	And I fill the form
	And I click getinternetprice button
	And I get to build confirmation page
	Then build confirmation page is as expected



