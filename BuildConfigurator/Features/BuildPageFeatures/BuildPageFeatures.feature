Feature: BuildPageFeatures
	To verify build page features and
	UI controlls

@features
Scenario: Verify clicking on accessory image opens overview
	Given I have navigated to RZR rzr-xp-turbo-eps-limited-edition build page
	When I get to build page
	And I click Protection accessory category
	And I click Mirrors accessory subcategory
	And I click image with description Folding Side Mirrors
	Then Accessory Folding Side Mirrors overview opens up

@features
Scenario: Verify restart button restarts the build
	Given I have navigated to RZR rzr-xp-4-turbo-s-indy-red build page
	When I get to build page
	And I click Protection accessory category
	And I click Mirrors accessory subcategory
	And I add specific Folding Side Mirrors accessory
	And Accessories '2881198' are displayed in build summary
	And I click build restart button
	And I click confirmation continue button
	Then Accessories '2881198' is not displayed in build summary

@features
Scenario: Verify save build functionality
	Given I have navigated to RZR rzr-xp-4-turbo-s-indy-red build page
	When I get to build page
	And I click Protection accessory category
	And I click Mirrors accessory subcategory
	And I add specific Folding Side Mirrors accessory
	And I click Save icon
	And I enter build name
	And I click save button
	And I login
	And I get to build page
	And I click Load Saved Build button
	Then Newly saved build is loaded
