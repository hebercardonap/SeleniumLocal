Feature: INDSteppedFlowTests
	Verify that build configurator steps 
	can be performed for a Indian products

@IND
Scenario: Verify IND build stepped process random model
	Given I have navigated to IND build model page
	When I select random model
	And I select random color
	And I click next button
	And I get to build page
	And I click Engine accessory category
	And I click Intake accessory subcategory
	And I add random available accessory
	And I click finished button
	And I get to build quote page
	And I fill the form
	And I click getinternetprice button
	And I get to build confirmation page
	Then build confirmation page is as expected

@IND
Scenario Outline: Verify IND stepped process build category Scout
	Given I have navigated to IND build category page
	When I select <Category> category
	And Category models are displayed
	And I select random model
	And I select random color
	And I click next button
	And I get to build page
	And I click Engine accessory category
	And I click Intake accessory subcategory
	And I add random available accessory
	And I click finished button
	And I get to build quote page
	And I fill the form
	And I click getinternetprice button
	And I get to build confirmation page
	Then build confirmation page is as expected
	Examples:
	| Category		|
	| scout			|
	| chief			|
	| springfield   |
	| chieftain     |
	| roadmaster    |
	| dark horse    |

