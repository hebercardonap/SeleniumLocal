Feature: AccessoryConflictTests
	Verify conflict rule is triggered
	when applicable for a particular brand

@conflicts @ran
Scenario: Verify conflict is triggered for RAN brand
	Given I have navigated to RAN ranger-crew-xp-900-sage-green build page
	When Build page loads
	And I select Utility from category carousel
	And I select Cargo & Bed Storage from subcategory carousel
	And I Add Front Hood Storage Rack from products
	And I close build summary from build page
	And I collapse Utility category carousel
	And I select Cab Components from category carousel
	And I select Windshields from subcategory carousel
	And I Add Flip-Down Full Windshield from products
	Then Conflict container is displayed

@conflicts @rzr
Scenario: Verify conflict is triggered for RZR brand
	Given I have navigated to RZR rzr-xp-1000-eps-trails-rocks-edition-cruiser-black build page
	When Build page loads
	And I select Utility from category carousel
	And I select Storage & Bed Accessories from subcategory carousel
	And I Add Spare Tire Carrier from products
	And I select Protection from category carousel
	And I select Custom Cage systems from subcategory carousel
	And I Add Cage system - Black from products
	Then Conflict container is displayed
