Feature: Product Price
	Product price for logged in user

@mytag
Scenario: Product price is 120sfor logged in user
	Given the user is logged in 
	And user name is not empty
	When the user name is Supreet
	Then the product price should be  120

Scenario: addtion of 2 nos
	Given the first number is 20
	And the second number is 10
	When the numbers are added
	Then the result should be 30
