Feature: BuildPagesFooterTests
	To verify v2 header features and functionality

@footer @ran
Scenario: Verifiy footer elements build model page
	Given I have navigated to RAN build model page
	When I get to build model page
	And Starting price is displayed on build model footer
	And Payment calculator is displayed on build model footer
	And Next button is not displayed on build model footer
	And Build summary toggle is not displayed on build model footer
	And I click footer calculator icon
	Then Calculator modal is displayed

@footer @ran
Scenario: Verify footer next button build color page
	Given I have navigated to RAN ranger-500 build color page
	When I get to build color page
	And I select random color
	And Next button is displayed on build model footer
	And I click next button build color footer
	Then I get to build page

@footer @ran
Scenario: Verify footer next button build package page
	Given I have navigated to RAN ranger-xp-1000-eps-steel-blue build package page
	When I get to build package page
	And Next button is displayed on build package footer
	And I click next button build package footer
	Then I get to build page

@header @ran
Scenario: Verify build summary toggle build page
	Given I have navigated to RAN ranger-500-sage-green build page
	When I get to build page
	And Build summary toggle is displayed on build footer
	And I click build summary toggle on build footer
	Then Build summary is displayed