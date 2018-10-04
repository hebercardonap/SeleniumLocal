Feature: SLGSteppedFlowTests
	Verify that build configurator steps 
	can be performed for a Indian products

@SLG stepped process
Scenario: Verify SLG S stepped flow
	Given I have navigated to SLG build model page
	When I select slingshot S
	And I get to build page
	And I click functional accessory category
	And I click Slingshade accessory subcategory
	And I add random available accessory
	And I click finished button old version
	And I get to build quote page
	And I fill the form
	And I click getinternetprice button
	And I get to build confirmation page
	Then build confirmation page is as expected

@SLG stepped process
Scenario: Verify SLG Grand Touring stepped flow
	Given I have navigated to SLG build model page
	When I select slingshot touring
	And I get to build page
	And I click functional accessory category
	And I click Covers accessory subcategory
	And I add random available accessory
	And I click finished button old version
	And I get to build quote page
	And I fill the form
	And I click getinternetprice button
	And I get to build confirmation page
	Then build confirmation page is as expected

@SLG stepped process
Scenario: Verify SLG SL stepped flow
	Given I have navigated to SLG build model page
	When I select slingshot SL
	And I select trim old version
	And I get to build page
	And I click functional accessory category
	And I click Slingshade accessory subcategory
	And I add random available accessory
	And I click finished button old version
	And I get to build quote page
	And I fill the form
	And I click getinternetprice button
	And I get to build confirmation page
	Then build confirmation page is as expected

@SLG stepped process
Scenario: Verify SLG SLR stepped flow
	Given I have navigated to SLG build model page
	When I select slingshot SLR
	And I select trim old version
	And I get to build page
	And I click functional accessory category
	And I click Slingshade accessory subcategory
	And I add random available accessory
	And I click finished button old version
	And I get to build quote page
	And I fill the form
	And I click getinternetprice button
	And I get to build confirmation page
	Then build confirmation page is as expected