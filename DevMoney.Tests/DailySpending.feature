Feature: DailySpending
	In order to track my spending
	as a busy developer
	I want to capture my expenses

@mytag
Scenario: Capture lunch expense
	Given I have my expense board open
	When i have entered 50 as my lunch expense
	And i have entered the description as 'burritos'
	Then my account should show my expense as '50 pesos, burritos'
	
