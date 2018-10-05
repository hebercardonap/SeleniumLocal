Feature: ATVSteppedFlowTests
	Verify that build configurator steps 
	can be performed for a ATV products

@ATV stepped process
Scenario Outline: Verify ATV stepped process no trim
	Given I have navigated to ATV build model page
	When I filter by <Family> family
	And I select family <Version>
	And I get to build page
	And I click <Category> accessory category
	And I click <Subcategory> accessory subcategory
	And I add random available accessory
	And I click finished button old version
	And I get to build quote page
	And I fill the form
	And I click getinternetprice button
	Then build confirmation page is as expected
	Examples:
	| Family     | Version | Category | Subcategory |
	| Recreation |Hunter   | Wheel    | Trail       |
	| Touring    |XP       | Wheel    | Trail       |
	| Sport      |Scrambler| Wheel    | Trail       |
	| Special    |570      | Wheel    | Trail       |
