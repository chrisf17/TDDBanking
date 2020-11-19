Feature: Addition
	In order to manage my accounts
	As a customer 
	I want to be able to withdraw cash from my account
	So that I can access my funds easily
	
@mytag
Scenario: With cash from an account with sufficient funds
	Given a current account has a balance or 500
	And the account is open
	When 200 is withdrawn
	Then the balance should be 300
    And an amount of 200 should be dispensed
