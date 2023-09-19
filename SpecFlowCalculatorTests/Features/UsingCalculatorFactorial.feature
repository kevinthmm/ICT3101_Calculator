Feature: UsingCalculatorFactorial
		In order to conquer Factorials
		As a Factorial enthusiast
		I want to understand a variety of Factorial operations

@Factorial
Scenario Outline: Zero Factorial
	Given I have a calculator
	When I have entered <value1> into the calculator and press factorial
	Then the factorial result should be 1
	Examples:
	|value1 |
	|0      |
	|1      |

@Factorial
Scenario: Normal Factorial
	Given I have a calculator
	When I have entered 4 into the calculator and press factorial
	Then the factorial result should be 24