Feature: BuildPagesHeaderTests
	To verify v2 header features and functionality

@header @ran
Scenario: Verifiy header elements build model page
	Given I have navigated to RAN build model page
	When I get to build model page
	And Ranger brand name is displayed build model header
	And I click close icon
	Then RAN brand home page is displayed

@header @ran
Scenario: Verify header elements build trim page
	Given I have navigated to RAN ranger-500 build trim page
	And I get to build trim page
	And Model 500 is displayed build trim header
	When I click close icon from build trim header
	Then RAN brand home page is displayed

@header @ran
Scenario: Verify header elements build color page
	Given I have navigated to RAN ranger-500 build color page
	When I get to build color page
	And Model 500 is displayed build color header
	And I click close icon from build color header
	Then RAN brand home page is displayed

@header @ran
Scenario: Verifies header elements build package page
	Given I have navigated to RAN ranger-xp-1000-eps-steel-blue build package page
	When I get to build package page
	And Model 1000 EPS is displayed build package header
	And I click close icon from build package header
	Then RAN brand home page is displayed

@header @ran
Scenario: Verifies header elements accessory build page
	Given I have navigated to RAN ranger-500-sage-green build page
	When I get to build page
	And Model 500 is displayed build header
	And Save icon is displayed on build header
	And Email icon is displayed on build header
	And I click on save from build header
	And Save build modal is displayed
	And I click cancel button
	And I get to build page
	And I click close icon from build header
	Then RAN brand home page is displayed

