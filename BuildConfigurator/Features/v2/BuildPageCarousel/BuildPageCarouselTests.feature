Feature: BuildPageCarouselTests
	To validate carousel new UI version functionality

@header @rzr
Scenario: Verify new carousel items
	Given I have navigated to RZR rzr-xp-4-turbo-s-indy-red build page
	When I get to build page
	And I select Audio & Lighting from category carousel
	And I select Audio & Tech from subcategory carousel
	And I Add Rear Audio Harness from products
