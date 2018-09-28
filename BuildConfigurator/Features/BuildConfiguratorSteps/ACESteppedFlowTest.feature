Feature: ACESteppedFlowTest
	Verify that build configurator steps 
	can be performed for ACE products

@ACE stepped process
Scenario: Verify ACE build stepped process random model
	Given I have navigated to ACE build model page
	When I select random model
	And I get to build page
	And I add random accessory avoid PRP
	And I click finished button
	And I get to build quote page
	And I fill the form
	And I click getinternetprice button
	And I get to build confirmation page
	Then build confirmation page is as expected
