Feature: UsingCalculatorDefectDensity
		In order to calculate the defect densities of the system releases
		As a System Quality Engineer
		I want to use my calculator to do this

@DefectDensity
Scenario: Calculate Defect Density
	Given I have a calculator
	When I have entered 100, and 50 into the calculator and press DD
	Then the DefectDensity result should be 2
	
@DefectDensity
Scenario: Calculate New Number of SSI
	Given I have a calculator
	When I have entered 50, 20, and 4 into the calculator and press KSSI
	Then the DefectDensity result should be 66