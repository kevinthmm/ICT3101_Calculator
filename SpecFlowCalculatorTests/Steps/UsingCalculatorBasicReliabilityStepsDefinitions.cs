using NUnit.Framework;

namespace SpecFlowCalculatorTests.Steps;

[Binding]
public class UsingCalculatorBasicReliabilityStepsDefinitions
{
    private double _result;
    private readonly CalculatorContext _calculatorContext;
    // private ArgumentException? _exception;
    
    //Context Injection for SpecFLow:
    public UsingCalculatorBasicReliabilityStepsDefinitions(CalculatorContext calculatorContext)
    {
        _calculatorContext = calculatorContext;
    }
    [When(@"I have entered (.*), (.*), and (.*) into the calculator and press CFIB")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndPressCfi(int p0, int p1, int p2)
    {
        _result = _calculatorContext.Calculator.CurrentFailureIntensity(p0, p1, p2);
    }

    [When(@"I have entered (.*), (.*), and (.*) into the calculator and press ANEFB")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAnef(int p0, int p1, int p2)
    {
        _result = _calculatorContext.Calculator.AverageExpectFail(p0, p1, p2);
    }

    [Then(@"the BasicReliability result should be (.*)")]
    public void ThenTheBasicReliabilityResultShouldBe(int p0)
    {
        Assert.That(_result, Is.EqualTo(p0));
    }
}