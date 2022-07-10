Feature: Basket

A short summary of the feature

@AddItemToBasket
Scenario: Adding item to basket
	Given User is logged in as standard_user with secret_sauce
	And Backpack item is clicked
	When Add to cart button is clicked
	And Basket button is clicked
	Then Backpack item is visible in the basket
	
