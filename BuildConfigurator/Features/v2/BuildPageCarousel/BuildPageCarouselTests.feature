Feature: BuildPageCarouselTests
	To validate carousel new UI version functionality

@header @rzr
Scenario: Verify header back navigation
	Given I have navigated to RZR rzr-xp-4-turbo-s-indy-red build page
	When I get to build page
	And Navigation bar is displayed
	And I navigate back to color
	And I navigate back to trim
	And I navigate back to models
	Then Choose model header is displayed
