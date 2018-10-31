Feature: DealerExperienceBuildTests
	To verify DEX features and functionality

@PRP
Scenario: Verify PRP is displayed when secondary accessory is removed
	Given I have navigated to RZR rzr-xp-1000-eps-ride-command-edition-black-pearl build DEX page
	When I get to build page
	And DEX build page specific elements are hidden
	And I click buildsummary button
	Then summary accessory social icons are not displayed
