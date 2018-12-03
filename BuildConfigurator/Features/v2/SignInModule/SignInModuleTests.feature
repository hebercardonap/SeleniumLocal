Feature: SignInModuleTests
	To verify functionality for new
	Sign In feature

@accountModal @ran
Scenario: Verify Sign In presence build page
	Given I have navigated to RAN ranger-500-sage-green build page
	When Build page loads
	And I click sing in from build page header
	And I login from build page
	And Build page loads
	And Account Icon is displayed on build page
	And I click Account icon from build page
	Then Account modal is displayed

@accountModal @ran
Scenario: Verify account modal navigation
	Given I have navigated to RAN ranger-500-sage-green build page
	When Build page loads
	And I click sing in from build page header
	And I login from build page
	And Build page loads
	And Account Icon is displayed on build page
	And I click orders from account modal on build page
	Then Orders page is displayed
	And I navigate back
	And I click saved vehicles from account modal on build page
	Then Saved vehicles page is displayed
	And I navigate back
	And I click Addresses from account modal on build page
	Then Addresses page is displayed
	And I navigate back
	And I click Account Information from account modal on build page
	Then Account Information page is displayed
	And I navigate back
	And I click logout from account modal on build page
	Then User is successfully logged out

