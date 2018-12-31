Feature: RANSteppedProcessTests
	Verify that build configurator steps 
	can be performed for a Ranger products

@steppedProcess @ran
Scenario: Verify RAN build stepped process two seat
	Given I have navigated to RAN models page
	When I select two seat model new version
	And I select random model new version
	And I wait until trims page loads
	And I select random trim new version
	And I wait until colors page loads
	And I select random color new version
	And I click next button from color page
	And I wait until accessories page loads
	And I select Wheel from category carousel
	And I select Trail from subcategory carousel
	And I Add Wheel & Tire Set from products
	And I click next button from accessories page
	And I wait until build summary is displayed
	And I click finished button from build summary
	And I get to build quote page
	And I fill the form
	And I click getinternetprice button
	And I wait until confirmation page loads
	Then Confirmation page is as expected

@steppedProcess @ran
Scenario: Verify RAN build stepped process three seat
	Given I have navigated to RAN models page
	When I select three seat models
	And I select random model
	And I select ranger non package trim
	And I select random color
	And I click next button
	And I get to build page
	And I select Wheel from category carousel
	And I select Trail from subcategory carousel
	And I Add Wheel & Tire Set from products
	And I click finished button
	And I get to build quote page
	And I fill the form
	And I click getinternetprice button
	And I get to build confirmation page
	Then build confirmation page is as expected
