using NUnit.Framework;

namespace SpecFlowCalculatorTests.Steps;

[Binding]
public class UsingCalculatorFactorialStepsDefinitions
{
    private double _result;
    private readonly CalculatorContext _calculatorContext;
    
    //Context Injection for SpecFLow:
    public UsingCalculatorFactorialStepsDefinitions(CalculatorContext calculatorContext)
    {
        _calculatorContext = calculatorContext;
    }
    
    [When(@"I have entered (.*) into the calculator and press factorial")]
    public void WhenIHaveEnteredIntoTheCalculatorAndPressFactorial(int p0)
    {
        _result = _calculatorContext.Calculator.Factorial(p0);
    }

    [Then(@"the factorial result should be (.*)")]
    public void ThenTheFactorialResultShouldBe(int p0)
    {
        Assert.That(_result, Is.EqualTo(p0));
    }
}