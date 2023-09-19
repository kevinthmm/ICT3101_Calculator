using ICT3101_Calculator;
using NUnit.Framework;

namespace SpecFlowCalculatorTests.Steps;

[Binding]
public class UsingCalculatorAdditionStepDefinitions
{
    private double _result;
    private readonly CalculatorContext _calculatorContext;

    //Context Injection for SpecFLow:
    public UsingCalculatorAdditionStepDefinitions(CalculatorContext calculatorContext)
    {
        _calculatorContext = calculatorContext;
    }
    
    [When(@"I have entered (.*) and (.*) into the calculator and press add")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAdd(int p0, int p1)
    {
        _result = _calculatorContext.Calculator.Add(p0, p1);
    }

    [Then(@"the result should be (.*)")]
    public void ThenTheResultShouldBe(int p0)
    {
        Assert.That(_result, Is.EqualTo(p0));
    }
}