Feature: AccessoryAddChangeRemTests
	To verify that accessory add
	functionality is as expected

@Add
Scenario: Verify button label changes to Remove
	Given I have navigated to RZR rzr-xp-1000-eps-ride-command-edition-black-pearl build page
	When I get to build page
	And I click Protection accessory category
	And I click Roofs accessory subcategory
	Then After adding Sport Roof remove button is displayed

@Change
Scenario: Verify change accessory functionality
	Given I have navigated to RZR rzr-xp-1000-eps-ride-command-edition-black-pearl build page
	When I get to build page
	And I click Protection accessory category
	And I click Roofs accessory subcategory
	And I add specific Sport Roof accessory
	And I add specific S4 Audio Roof accessory
	Then Accessories '2882064' are displayed in build summary

@Add
Scenario: Verify add accessory from info modal
	Given I have navigated to RAN ranger-crew-570-4-sage-green build page
	When I get to build page
	And I click Wheel & Tire Sets accessory category
	And I click Utility accessory subcategory
	And I click info button for Amplify accessory
	And I click add button from info modal
	And I click close button from info modal
	Then Accessories '2882390' are displayed in build summary

@Add
Scenario: Verify add accessory remove info modal
	Given I have navigated to IND scout-bobber-thunder-black build page
	When I get to build page
	And I click Engine Performance accessory category
	And I click Stage 1 Air Intake accessory subcategory
	And I add specific Air Intake accessory
	And I click info button for Air Intake accessory
	And I click remove button from info modal
	And I click close button from info modal
	Then Accessories '2882519' is not displayed in build summary

@Add
Scenario: Verify remove option hidden when accessory removed build summary
	Given I have navigated to RZR rzr-xp-turbo-s-indy-red build page
	When I get to build page
	And I click Protection accessory category
	And I click Windshields accessory subcategory
	And I add specific Half Windshield accessory
	And I remove product id 2883135 from build summary
	Then After removing Half Windshield remove button is hidden
