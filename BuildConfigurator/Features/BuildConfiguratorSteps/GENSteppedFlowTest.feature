Feature: GENSteppedFlowTest
	Verify that build configurator steps 
	can be performed for General products

@GEN
Scenario: Verify GEN build stepped process two seat
	Given I have navigated to GEN build model page
	When I select two seat option
	And I select unique color General model
	And I select trim
	And I get to build page
	And I add random ranger tires accessory
	And I click finished button
	And I get to build quote page
	And I fill the form
	And I click getinternetprice button
	And I get to build confirmation page
	Then build confirmation page is as expected

@GEN
Scenario: Verify GEN build stepped process two seat color
	Given I have navigated to GEN build model page
	When I select two seat option
	And I select General model color pick
	And I select General trim color pick
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

@GEN
Scenario: Verify GEN build stepped process four seat
	Given I have navigated to GEN build model page
	When I select four seat option
	And I select unique color General model
	And I select trim
	And I get to build page
	And I add random ranger tires accessory
	And I click finished button
	And I get to build quote page
	And I fill the form
	And I click getinternetprice button
	And I get to build confirmation page
	Then build confirmation page is as expected
