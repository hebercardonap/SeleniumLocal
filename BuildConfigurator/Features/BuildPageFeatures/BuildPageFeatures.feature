Feature: BuildPageFeatures
	To verify build page features and
	UI controlls

@features @rzr
Scenario: Verify clicking on accessory image opens overview
	Given I have navigated to RZR rzr-xp-turbo-eps-limited-edition build page
	When I get to build page
	And I click Protection accessory category
	And I click Mirrors accessory subcategory
	And I click image with description Folding Side Mirrors
	Then Accessory Folding Side Mirrors overview opens up

@features @rzr
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

@features @rzr
Scenario: Verify save build functionality
	Given I have navigated to RZR rzr-xp-4-turbo-s-indy-red build page
	When I get to build page
	And I click Protection accessory category
	And I click Mirrors accessory subcategory
	And I add specific Folding Side Mirrors accessory
	And I click save icon
	And I enter build name
	And I click save button
	And I login from build page
	And I get to build page
	And I click Load Saved Build button
	Then Newly saved build is loaded

@features @rzr
Scenario: Verify navigation bar and social icons are present
	Given I have navigated to RZR rzr-xp-4-turbo-s-indy-red build page
	When I get to build page
	And Navigation bar and icon container is displayed
	And I click buildsummary button
	Then summary accessory social icons are displayed

@features @rzr
Scenario: Verify navigation back from build to models
	Given I have navigated to RZR rzr-xp-4-turbo-s-indy-red build page
	When I get to build page
	And Navigation bar and icon container is displayed
	And I navigate back to color
	And I navigate back to trim
	And I navigate back to models
	Then Choose model header is displayed

@features @rzr
Scenario: Verify accessory cards data present for RZR
	Given I have navigated to RZR build model page
	When I select four seat option
	And I select random model
	And I select trim
	And I select random color
	And I click next button
	And I get to build page
	Then Data is present for category subcategory and accessory cards

@features @ran
Scenario: Verify accessory cards data present for RAN
	Given I have navigated to RAN build model page
	When I select two seat option
	And I select random model
	And I select trim
	And I select random color
	And I click next button
	And I get to build page
	Then Data is present for category subcategory and accessory cards

@features @atv
Scenario: Verify accessory cards data present for ATV
	Given I have navigated to ATV build model page
	When I select two seat option
	And I select random model
	And I select trim
	And I select random color
	And I click next button
	And I get to build page
	Then Data is present for category subcategory and accessory cards

@features @ace
Scenario: Verify accessory cards data present for ACE
	Given I have navigated to ACE build model page
	When I select random model
	And I get to build page
	Then Data is present for category subcategory and accessory cards

@features @gen
Scenario: Verify accessory cards data present for GEN
	Given I have navigated to GEN build model page
	When I select four seat option
	And I select unique color General model
	And I select trim
	And I get to build page
	Then Data is present for category subcategory and accessory cards

@features @gem
Scenario: Verify accessory cards data present for GEM
	Given I have navigated to GEM build model page
	When I filter by Passenger family
	And I select random available version
	And I get to build page
	Then Data is present for category subcategory and accessory cards

@features @ind
Scenario: Verify accessory cards data present for IND
	Given I have navigated to IND build category page
	When I select springfield category
	And Category models are displayed
	And I select random model
	And I select random color
	And I click next button
	And I get to build page
	Then Data is present for category subcategory and accessory cards

@features @slg
Scenario: Verify accessory cards data present for SLG
	Given I have navigated to SLG build model page
	When I select slingshot touring
	And I get to build page
	Then Data is present for category subcategory and accessory cards

@features @sno
Scenario: Verify accessory cards data present for SNO
	Given I have navigated to SNO build model page
	When I filter by rush family
	And I select random available version
	And I select trim old version
	And I get to build page
	Then Data is present for category subcategory and accessory cards
