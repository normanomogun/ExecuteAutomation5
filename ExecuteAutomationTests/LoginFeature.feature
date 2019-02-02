Feature: LoginFeature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario Outline: Login with valid credentials 
	Given I am on login page 
	When I enter <username> and <password>
	And I press login
	Then I should be successfully logged in 
	
	Examples: 
	| username | password |
	| norman   | goodguy  |
