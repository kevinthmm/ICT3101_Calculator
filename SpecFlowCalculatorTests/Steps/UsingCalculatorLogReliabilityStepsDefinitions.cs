using NUnit.Framework;

namespace SpecFlowCalculatorTests.Steps;

[Binding]
public class UsingCalculatorLogReliabilityStepsDefinitions
{
    private double _result;
    private readonly CalculatorContext _calculatorContext;
    // private ArgumentException? _exception;
    
    //Context Injection for SpecFLow:
    public UsingCalculatorLogReliabilityStepsDefinitions(CalculatorContext calculatorContext)
    {
        _calculatorContext = calculatorContext;
    }
    [When(@"I have entered (.*), (.*), and (.*) into the calculator and press CFIL")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndPressCfil(double p0, double p1, double p2)
    {
        _result = _calculatorContext.Calculator.CurrentFailureIntensityLog(p0, p1, p2);
    }

    [When(@"I have entered (.*), (.*), and (.*) into the calculator and press ANEFL")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAnefl(double p0, double p1, double p2)
    {
        _result = _calculatorContext.Calculator.AverageExpectFailLog(p0, p1, p2);
    }

    [Then(@"the LogReliability result should be (.*)")]
    public void ThenTheLogReliabilityResultShouldBe(decimal p0)
    {
        Assert.That(_result, Is.EqualTo(p0));
    }
}