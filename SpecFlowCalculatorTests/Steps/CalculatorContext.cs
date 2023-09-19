using ICT3101_Calculator;

namespace SpecFlowCalculatorTests.Steps;

[Binding]
public class CalculatorContext
{
    public CalculatorContext(Calculator calculator)
    {
        Calculator = calculator;
    }

    public Calculator Calculator { get; set; }
}

