using NUnit.Framework;

namespace SpecFlowCalculatorTests.Steps;

[Binding]
public class UsingCalculatorAvailabilityStepsDefinitions
{
    private double _result;
    private readonly CalculatorContext _calculatorContext;
    private ArgumentException? _exception;
    
    //Context Injection for SpecFLow:
    public UsingCalculatorAvailabilityStepsDefinitions(CalculatorContext calculatorContext)
    {
        _calculatorContext = calculatorContext;
    }
    [When(@"I have entered (.*) and (.*) into the calculator and press MTBF")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndPressMtbf(int p0, int p1)
    {
        try
        {
            _result = _calculatorContext.Calculator.Mtbf(p0, p1);
        }
        catch (ArgumentException? ex)
        {
            _exception = ex;
        }
    }

    [When(@"I have entered (.*) and (.*) into the calculator and press Availability")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAvailability(double p0, double p1)
    {
        try
        {
            _result = _calculatorContext.Calculator.Availability(p0, p1);
        }
        catch (ArgumentException? ex)
        {
            _exception = ex;
        }
    }

    [Then(@"the availability result should be (.*)")]
    public void ThenTheAvailabilityResultShouldBe(double p0)
    {
        var round = Math.Round(p0, 2, MidpointRounding.AwayFromZero);
        Assert.That(_result, Is.EqualTo(round));
    }
    
    [When(@"I have entered (.*) and (.*) into the MTBF calculator, the functions throws an Argument Exception")]
    public void WhenIHaveEnteredAndIntoTheCalculatorTheFunctionsThrowsAnArgumentException(int p0, int p1)
    {
        Assert.That(() => _calculatorContext.Calculator.Mtbf(p0,p1), Throws.ArgumentException);
    }

    [When(@"I have entered (.*) and (.*) into the Availability calculator, the functions throws an Argument Exception")]
    public void WhenIHaveEnteredAndIntoTheAvailabilityCalculatorTheFunctionsThrowsAnArgumentException(int p0, int p1)
    {
        Assert.That(() => _calculatorContext.Calculator.Availability(p0,p1), Throws.ArgumentException);
    }
}