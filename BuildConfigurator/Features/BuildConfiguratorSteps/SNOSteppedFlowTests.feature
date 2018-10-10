Feature: SNOSteppedFlowTests
	Verify that build configurator steps 
	can be performed for a Ranger products

@SNO
Scenario: Verify SNO RUSH build stepped process
	Given I have navigated to SNO build model page
	When I filter by rush family
	And I select random available version
	And I select trim old version
	And I get to build page
	And I click Windshields accessory category
	And I click Tall accessory subcategory
	And I add random available accessory
	And I click finished button old version
	And I get to build quote page
	And I fill the form
	And I click getinternetprice button
	And I get to build confirmation page
	Then build confirmation page is as expected

@SNO
Scenario: Verify SNO TITAN build stepped process
	Given I have navigated to SNO build model page
	When I filter by TITAN family
	And I select random available version
	And I get to build page
	And I click Windshields accessory category
	And I click Tall accessory subcategory
	And I add random available accessory
	And I click finished button old version
	And I get to build quote page
	And I fill the form
	And I click getinternetprice button
	And I get to build confirmation page
	Then build confirmation page is as expected


@SNO
Scenario Outline: Verify SNO Families build stepped process
	Given I have navigated to SNO build model page
	When I filter by <Family> family
	And I select family <Version>
	And I select trim old version
	And I get to build page
	And I click Windshields accessory category
	And I click Tall accessory subcategory
	And I add random available accessory
	And I click finished button old version
	And I get to build quote page
	And I fill the form
	And I click getinternetprice button
	And I get to build confirmation page
	Then build confirmation page is as expected
	Examples:
	| Family		| Version |
	| RMK			| 146     |
	| Switchback    | XCR     |
	| INDY			| EVO     |
	| Voyageur		| 144     |