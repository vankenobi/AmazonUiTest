Feature: AddToBasket
	Search a product, add to basket and then check the shopping cart counter 

@AddToBasket
Scenario: Search a product and add to basket 
	#steps
	Given I open the amazon main page
	And Accept the all cookies
	And I given the searchtext to search box
	| SearchText |
	| WH1000xm4 |
	And I click the search button
	And I click the card of product
	And I click the addtobasket button
	And I click the shopping card button
	Then I should see the number of one in count