Feature: RangerSteppedFlowProcess
	Verify that build configurator steps 
	can be performed for a Ranger products

@Ranger stepped process
Scenario: Verify RAN build stepped process two seat
	Given I have navigated to RAN build model page
	When I select two seat option
	And I select random model
	And I select trim
	And I select random color
	And I click next button
	And I get to build page
	And I add random ranger tires accessory
	And I click finished button
	And I get to build quote page
	And I fill the form
	And I click getinternetprice button
	And I get to build confirmation page
	Then build confirmation page is as expected

@Ranger stepped process
Scenario: Verify RAN build stepped process three seat
	Given I have navigated to RAN build model page
	When I select three seat option
	And I select random model
	And I select trim
	And I select random color
	And I click next button
	And I get to build page
	And I add random accessory avoid PRP
	And I click finished button
	And I get to build quote page
	And I fill the form
	And I click getinternetprice button
	And I get to build confirmation page
	Then build confirmation page is as expected

@Ranger stepped process
Scenario: Verify RAN build stepped process four seat
	Given I have navigated to RAN build model page
	When I select four seat option
	And I select random model
	And I select trim
	And I select random color
	And I click next button
	And I get to build page
	And I add random ranger tires accessory
	And I click finished button
	And I get to build quote page
	And I fill the form
	And I click getinternetprice button
	And I get to build confirmation page
	Then build confirmation page is as expected

@Ranger stepped process
Scenario: Verify RAN build stepped process six seat
	Given I have navigated to RAN build model page
	When I select six seat option
	And I select random model
	And I select trim
	And I select random color
	And I click next button
	And I get to build page
	And I add random accessory avoid PRP
	And I click finished button
	And I get to build quote page
	And I fill the form
	And I click getinternetprice button
	And I get to build confirmation page
	Then build confirmation page is as expected
