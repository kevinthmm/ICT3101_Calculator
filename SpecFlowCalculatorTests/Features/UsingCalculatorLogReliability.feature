Feature: UsingCalculatorLogReliability
In order to calculate the Log Musa model's failures/intensities
As a System Quality Engineer
I want to use my calculator to do this

@LogReliability
Scenario: Calculate Current Failure Intensity with Log
	Given I have a calculator
	When I have entered 10, 0.02, and 50 into the calculator and press CFIL
	Then the LogReliability result should be 3.68 
	
@LogReliability
Scenario: Calculate Average Number of Expected Failure Log
	Given I have a calculator
	When I have entered 10, 0.02, and 10 into the calculator and press ANEFL
	Then the LogReliability result should be 55