Feature: BuildPageFeaturesTests
	To verify build page features and
	UI controlls

@mytag@features @rzr
Scenario: Verify clicking on accessory image opens overview
	Given I have navigated to RZR rzr-xp-turbo-eps-limited-edition build page
	When I get to build page
	And I select Protection from category carousel
	And I select Mirrors from subcategory carousel
	And I click see details link from Convex Rear View Mirror description
	Then Product Info is displayed
