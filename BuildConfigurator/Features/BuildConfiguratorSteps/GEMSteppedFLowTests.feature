Feature: GEMSteppedFLowTests
	Verify that build configurator steps 
	can be performed for a GEM products

@GEM
Scenario Outline: Verify GEM build stepped process
	Given I have navigated to GEM build model page
	When I filter by <Family> family
	And I select random available version
	And I get to build page
	And I click <Category> accessory category
	And I click <Subcategory> accessory subcategory
	And I add random available accessory
	And I click finished button old version
	And I get to build quote page
	And I fill the form
	And I click on Personal use option
	And I click getinternetprice button
	Then GEM build confirmation page is as expected
	Examples:
	| Family    | Category | Subcategory |
	| Passenger | Comfort  | Seats       |
	| Utility   | Power    | Battery     |
