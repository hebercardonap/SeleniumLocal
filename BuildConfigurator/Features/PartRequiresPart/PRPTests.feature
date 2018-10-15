Feature: PRPTests
	Verify PRP rule is triggered
	when applicable for a particular brand

@PRP
Scenario: Verify conflict is triggered for RZR brand
	Given I have navigated to RZR rzr-xp-1000-eps-ride-command-edition-black-pearl build page
	When I get to build page
	And I click Utility & Performance accessory category
	And I click Winches accessory subcategory
	And I add specific Winch Cover Kit accessory
	And PRP container is displayed
	And I select accessory by product ID 2882240
	And I click buildsummarybutton button
	Then Accessories '2884118,2882240' are displayed in build summary

