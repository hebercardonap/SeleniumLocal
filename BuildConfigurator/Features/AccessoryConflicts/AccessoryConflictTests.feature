Feature: AccessoryConflictTests
	Verify conflict rule is triggered
	when applicable for a particular brand

@CPQ_Conflicts
Scenario: Verify conflict is triggered for IND brand
	Given I have navigated to IND chieftain-steel-gray build page
	When I get to build page
	And I click Storage accessory category
	And I click Quick Release accessory subcategory
	And I add specific steel gray accessory
	And I click Seats accessory category
	And I click Passenger sissybar accessory subcategory
	And I add random available accessory
	Then Conflict container is displayed

@CPQ_Conflicts
Scenario: Verify conflict is triggered for ATV brand
	Given I have navigated to ATV sportsman-450-ho-indy-red build page
	When I get to build page
	And I click Protection accessory category
	And I click Windshields accessory subcategory
	And I add random available accessory
	And I click handguards accessory subcategory
	And I add random available accessory
	Then Conflict container is displayed

@CPQ_Conflicts
Scenario: Verify conflict is triggered for SLG brand
	Given I have navigated to SLG slingshot-s-white-lightning build page
	When I get to build page
	And I click Functional accessory category
	And I click Performance accessory subcategory
	And I add specific wheel kit accessory
	And I click Style accessory category
	And I click narrow fenders accessory subcategory
	And I add random available accessory
	Then Conflict container is displayed

@CPQ_Conflicts
Scenario: Verify conflict is triggered for GEN brand
	Given I have navigated to GEN general-4-1000-eps-matte-white-metallic build page
	When I get to build page
	And I click Utility accessory category
	And I click Bumpers accessory subcategory
	And I add specific Front Sport accessory
	And I click cargo & bed storage accessory subcategory
	And I add specific Front Hood Storage Rack accessory
	Then Conflict container is displayed

@CPQ_Conflicts @Retry
Scenario: Verify conflict is triggered for ACE brand
	Given I have navigated to ACE ace-570-eps-ghost-gray build page
	When I get to build page
	And I click Utility accessory category
	And I click Rack Extenders accessory subcategory
	And I add specific Steel Bed Extender accessory
	And I click Storage accessory subcategory
	And I add specific Rear Cargo Box accessory
	Then Conflict container is displayed

@CPQ_Conflicts
Scenario: Verify conflict is triggered for RZR brand
	Given I have navigated to RZR rzr-xp-1000-eps-trails-rocks-edition-cruiser-black build page
	When I get to build page
	And I click Utility accessory category
	And I click Storage & Bed Accessories accessory subcategory
	And I add specific Spare Tire Carrier accessory
	And I click Protection accessory category
	And I click Custom Cage systems accessory subcategory
	And I add specific Cage system - Black accessory
	Then Conflict container is displayed

@CPQ_Conflicts
Scenario: Verify conflict is triggered for SNO brand
	Given I have navigated to SNO switchback/600-switchback-xcr build page
	When I get to build page
	And I click Storage & Racks accessory category
	And I click Underseat Bags accessory subcategory
	And I add specific Rear Seat Bag accessory
	And I click Cargo Rack Bags accessory subcategory
	And I add specific Rear Sport Rack Bag accessory
	Then Conflict container is displayed

@CPQ_Conflicts
Scenario: Verify conflict is triggered for RAN brand
	Given I have navigated to RAN ranger-crew-xp-900-sage-green build page
	When I get to build page
	And I click Utility accessory category
	And I click Cargo & Bed Storage accessory subcategory
	And I add specific Front Hood Storage Rack accessory
	And I click Cab Components accessory category
	And I click Windshields accessory subcategory
	And I add specific Flip-Down Full Windshield accessory
	Then Conflict container is displayed

@CPQ_Conflicts
Scenario: Verify conflict is triggered for GEM brand
	Given I have navigated to GEM el-xd build page
	When I get to build page
	And I click Power accessory category
	And I click Battery accessory subcategory
	And I add specific Distance AGM accessory
	And I click Charging accessory subcategory
	And I add specific Level 2 Charger accessory
	Then Conflict container is displayed