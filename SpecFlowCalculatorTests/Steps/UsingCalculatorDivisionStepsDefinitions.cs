using ICT3101_Calculator;
using NUnit.Framework;

namespace SpecFlowCalculatorTests.Steps;

[Binding]
public class UsingCalculatorDivisionStepsDefinitions
{
    private double _result;
    private readonly CalculatorContext _calculatorContext;
    
    //Context Injection for SpecFLow:
    public UsingCalculatorDivisionStepsDefinitions(CalculatorContext calculatorContext)
    {
        _calculatorContext = calculatorContext;
    }
    
    [When(@"I have entered (.*) and (.*) into the calculator and press divide")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDivide(int p0, int p1)
    {
        // Fill in your definitions
        _result = _calculatorContext.Calculator.Divide(p0, p1);
    }

    [Then(@"the division result should be (.*)")]
    public void ThenTheDivisionResultShouldBe(decimal p0)
    {
        Assert.That(_result, Is.EqualTo(p0));
    }

    [Then(@"the division result equals positive_infinity")]
    public void ThenTheDivisionResultEqualsPositiveInfinity()
    {
        Assert.That(_result, Is.EqualTo(int.MaxValue));
    }
}