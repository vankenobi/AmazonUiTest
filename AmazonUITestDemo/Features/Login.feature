Feature: Login
	Login the amazon website with email and password

@Login
Scenario: Login the amazon website
	#steps
	Given I open the amazon login page
	And I enter the email
	| Email |
	| amazon mail |
	And I click the continue button
	And I enter the password
	| Password |
	| amazon pass |
	And I click the login button
	Then I should see the my name

