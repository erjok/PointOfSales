﻿Feature: AddingProductWithSalesCombinationsToOrder
	In order to offer discount
	As a salesman
	I want to be able to add a product with sales combinations to an order

Scenario: Adding sales combination to order
	Given I have an empty order	
	When I add sales combination 2 to order
	Then order should contain both products
	 And total price should have discount

Scenario: Adding sales combination for product which already added to order
	Given I have an empty order
	When I add product to order
	 And I add sales combination 2 to order
	Then order should contain both products
 	 And total price should have discount

Scenario: Adding sales combination for products which both added to order
	Given I have an empty order
	When I add product to order
	And I add sub product to order
	And I add sales combination 1 to order
	Then order should contain both products
	And items quantity should be 2