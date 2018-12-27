Feature: BuildPageFeaturesTests
	To verify build page features and
	UI controlls

@mytag@features @rzr
Scenario: Verify clicking see details link opens product info
	Given I have navigated to RZR rzr-xp-turbo-eps-limited-edition build page
	When I get to build page
	And I select Protection from category carousel
	And I select Mirrors from subcategory carousel
	And I click see details link from Convex Rear View Mirror description
	Then Product Info is displayed

@features @rzr
Scenario: Verify save build functionality
	Given I have navigated to RZR rzr-xp-4-turbo-s-indy-red build page
	When Build page loads
	And I select Protection from category carousel
	And I select Mirrors from subcategory carousel
	And I Add Folding Side Mirrors from products
	And I click header save icon from build page
	And I enter build name
	And I click save button
	And I login from build page
	And Build page loads
	And I click Load Saved Build button
	Then Newly saved build is loaded
