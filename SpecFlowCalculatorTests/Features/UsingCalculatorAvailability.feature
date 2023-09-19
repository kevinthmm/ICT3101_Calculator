Feature: UsingCalculatorAvailability
In order to calculate MTBF and Availability
As someone who struggles with math
I want to be able to use my calculator to do this

MTBF = MTTF + MTTR
Availability = MTTF / MTBF = MTTF / (MTTF + MTTR)
    
@Availability
Scenario: Calculating MTBF
    Given I have a calculator
    When I have entered 200 and 10 into the calculator and press MTBF
    Then the availability result should be 210
    
@Availability
Scenario: Calculating Availability
    Given I have a calculator
    When I have entered 200 and 210 into the calculator and press Availability
    Then the availability result should be 0.952

@Availability
Scenario Outline: MTBF Negative Input
    Given I have a calculator
    When I have entered <value1> and <value2> into the MTBF calculator, the functions throws an Argument Exception
    Examples: 
    | value1 | value2 |
    | -10    | 200    |
    | 200    | -10    |
    | -10    | -2     |
    
@Availability
Scenario Outline: Availability Negative Input
    Given I have a calculator
    When I have entered <value1> and <value2> into the Availability calculator, the functions throws an Argument Exception
    Examples: 
    | value1 | value2 |
    | -10    | 200    |
    | 200    | -10    |
    | -10    | -2     |