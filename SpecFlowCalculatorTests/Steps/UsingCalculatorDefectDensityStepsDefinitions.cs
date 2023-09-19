using NUnit.Framework;

namespace SpecFlowCalculatorTests.Steps;

[Binding]
public class UsingCalculatorDefectDensityStepsDefinitions
{
    private double _result;
    private readonly CalculatorContext _calculatorContext;
    // private ArgumentException? _exception;
    
    //Context Injection for SpecFLow:
    public UsingCalculatorDefectDensityStepsDefinitions(CalculatorContext calculatorContext)
    {
        _calculatorContext = calculatorContext;
    }
    [When(@"I have entered (.*), and (.*) into the calculator and press DD")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDd(int p0, int p1)
    {
        _result = _calculatorContext.Calculator.DefectDensity(p0, p1);
    }

    [When(@"I have entered (.*), (.*), and (.*) into the calculator and press KSSI")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndPressKssi(int p0, int p1, int p2)
    {
        _result = _calculatorContext.Calculator.KssiCurrent(p0, p1, p2);
    }

    [Then(@"the DefectDensity result should be (.*)")]
    public void ThenTheDefectDensityResultShouldBe(int p0)
    {
        Assert.That(_result, Is.EqualTo(p0));
    }
}