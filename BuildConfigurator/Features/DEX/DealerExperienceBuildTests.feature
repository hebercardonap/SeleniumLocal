Feature: DealerExperienceBuildTests
	To verify DEX features and functionality

@dealerExperience
Scenario: Verify items hidden for dealer experience
	Given I have navigated to RZR rzr-xp-1000-eps-ride-command-edition-black-pearl build DEX page
	When I get to build page
	And DEX build page specific elements are hidden
	And I click buildsummary button
	Then summary accessory social icons are not displayed

@dealerExperience
Scenario: Verify virtual keyboard is displayed on build page
	Given I have navigated to RZR rzr-xp-1000-eps-ride-command-edition-black-pearl build DEX page
	When I get to build page
	And I click calculator icon
	And I click msrp form field
	Then Virtual keyboard is displayed
