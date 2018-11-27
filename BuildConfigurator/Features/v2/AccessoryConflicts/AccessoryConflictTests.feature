Feature: AccessoryConflictTests
	Verify conflict rule is triggered
	when applicable for a particular brand

@conflicts @ran
Scenario: Verify conflict is triggered for RAN brand
	Given I have navigated to RAN ranger-crew-xp-900-sage-green build page
	When I get to build page
	And I select Utility from category carousel
	And I select Cargo & Bed Storage from subcategory carousel
	And I Add Front Hood Storage Rack from products
	And I close build summary from build page
	And I collapse Utility category carousel
	And I select Cab Components from category carousel
	And I select Windshields from subcategory carousel
	And I Add Flip-Down Full Windshield from products
	Then Conflict container is displayed
