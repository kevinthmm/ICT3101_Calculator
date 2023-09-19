namespace SpecFlowCalculatorTests.Steps
{
    [Binding]
    public sealed class CommonStepDefinitions
    {
        private readonly CalculatorContext _calculatorContext;

        public CommonStepDefinitions(CalculatorContext calculatorContext)
        {
            _calculatorContext = calculatorContext;
        }

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            // The calculator is already instantiated in the context.
            // No need to instantiate it again.
        }
    }
}