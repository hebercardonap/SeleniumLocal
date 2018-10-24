Feature: PRPTests
	Verify PRP rule is triggered
	when applicable for a particular brand

@PRP
Scenario: Verify PRP is triggered for RZR brand
	Given I have navigated to RZR rzr-xp-1000-eps-ride-command-edition-black-pearl build page
	When I get to build page
	And I click Utility & Performance accessory category
	And I click Winches accessory subcategory
	And I add specific Winch Cover Kit accessory
	And PRP container is displayed
	And I select accessory by product ID 2882240
	And I click buildsummarybutton button
	Then Accessories '2884118,2882240' are displayed in build summary

@PRP
Scenario: Verify PRP is triggered for RAN brand
	Given I have navigated to RAN ranger-crew-570-4-sage-green build page
	When I get to build page
	And I click Utility accessory category
	And I click Cargo & Bed Storage accessory subcategory
	And I add specific XL Transport accessory
	And PRP container is displayed
	And I select accessory by product ID 2884106
	And I click buildsummarybutton button
	Then Accessories '2882430,2884106' are displayed in build summary

@PRP
Scenario: Verify PRP is triggered for GEN brand
	Given I have navigated to GEN general-1000-eps-deluxe-orange-rust build page
	When I get to build page
	And I click Cab Components accessory category
	And I click Windshields accessory subcategory
	And I add specific Windshield Wiper Kit accessory
	And PRP container is displayed
	And I select accessory by product ID 2881108
	And I click buildsummarybutton button
	Then Accessories '2881090,2881108' are displayed in build summary

@PRP
Scenario: Verify PRP is triggered for ACE brand
	Given I have navigated to ACE ace-570-eps-ghost-gray build page
	When I get to build page
	And I click Utility accessory category
	And I click Ligthing accessory subcategory
	And I add specific Dual Row LED Light Bar accessory
	And PRP container is displayed
	And I select accessory by product ID 2881147
	And I click buildsummary button
	Then Accessories '2883107,2881147' are displayed in build summary

@PRP
Scenario: Verify PRP is triggered for ATV brand
	Given I have navigated to ATV sportsman-450-ho-utility-edition-ghost-gray build page
	When I get to build page
	And I click Utility accessory category
	And I click Storage accessory subcategory
	And I add specific Gun Boot accessory
	Then PRP container is displayed

@PRP
Scenario: Verify PRP is triggered for SLG brand
	Given I have navigated to SLG slingshot-s-white-lightning build page
	When I get to build page
	And I click Style accessory category
	And I click Wide Fenders accessory subcategory
	And I add specific Ghost Gray accessory
	Then PRP container is displayed

@PRP
Scenario: Verify PRP is triggered for IND brand
	Given I have navigated to IND springfield-thunder-black build page
	When I get to build page
	And I click Storage & Luggage accessory category
	And I click Touring Essentials accessory subcategory
	And I add specific Pinnacle Conchos accessory
	And PRP container is displayed
	And I select accessory by product ID 2879667-05
	And I click buildsummarybutton button
	Then Accessories '2879674-266,2879667-05' are displayed in build summary

@PRP
Scenario: Verify PRP is triggered for SNO brand
	Given I have navigated to SNO switchback/600-switchback-sp-144-es build page
	When I get to build page
	And I click Storage & Racks accessory category
	And I click Cargo Rack Bags accessory subcategory
	And I add specific Under Rack Bag accessory
	Then PRP container is displayed

@PRP
Scenario: Verify PRP is triggered for GEM brand
	Given I have navigated to GEM el-xd build page
	When I get to build page
	And I click Exterior accessory category
	And I click Roof accessory subcategory
	And I add specific Solar Panel accessory
	Then PRP container is displayed

@PRP
Scenario: Verify PRP is displayed when secondary accessory is removed
	Given I have navigated to RZR rzr-xp-1000-eps-ride-command-edition-black-pearl build page
	When I get to build page
	And I click Utility & Performance accessory category
	And I click Winches accessory subcategory
	And I add specific Winch Cover Kit accessory
	And PRP container is displayed
	And I select accessory by product ID 2882240
	And I click buildsummarybutton button
	And I remove product id 2882240 from build summary
	Then PRP container is displayed

@PRP
Scenario: Verify primary accessory is not removed when removing secondary acceossory
	Given I have navigated to RZR rzr-xp-1000-eps-ride-command-edition-black-pearl build page
	When I get to build page
	And I click Audio & Lighting accessory category
	And I click Lighting accessory subcategory
	And I add specific LED Spot Light accessory
	And PRP container is displayed
	And I select accessory by product ID 2884019-293
	And I click buildsummarybutton button
	And I remove product id 2882076 from build summary
	Then Accessories '2884019-293' are displayed in build summary

