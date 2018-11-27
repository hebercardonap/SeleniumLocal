Feature: PartRequiresPartTests
	Verify PRP rule is triggered
	when applicable for a particular brand

@PRP @ran
Scenario: Verify PRP is triggered for RAN brand
	Given I have navigated to RAN ranger-500-sage-green build page
	When I get to build page
	And I select Utility from category carousel
	And I select Cargo & Bed Storage from subcategory carousel
	And I Add XL Transport from products
	And PRP container is displayed
	And I select accessory by product ID 2884106
	And I click buildsummary button
	Then Accessories '2882430,2884106' are displayed in build summary
