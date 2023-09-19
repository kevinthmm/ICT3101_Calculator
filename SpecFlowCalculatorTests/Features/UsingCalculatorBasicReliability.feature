Feature: UsingCalculatorBasicReliability
		In order to calculate the Basic Musa model's failures/intensities
		As a Software Quality Metric enthusiast
		I want to use my calculator to do this

@BasicReliability
Scenario: Calculate Current Failure Intensity
	Given I have a calculator
	When I have entered 10, 50, and 100 into the calculator and press CFIB
	Then the BasicReliability result should be 5 
	
@BasicReliability
Scenario: Calculate Average Expected Failure
	Given I have a calculator
	When I have entered 100, 10, and 10 into the calculator and press ANEFB
	Then the BasicReliability result should be 63