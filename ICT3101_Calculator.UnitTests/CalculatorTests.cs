
namespace ICT3101_Calculator.UnitTests;
public class CalculatorTests
{
    private Calculator? _calculator;

    [SetUp]
    public void Setup()
    {
        // Arrange
        _calculator = new Calculator();
    }
    [Test]
    public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
    {
        // Act
        double result = _calculator.Add(10, 20);
        // Assert
        Assert.That(result, Is.EqualTo(30));
    }
    [Test]
    public void Subtract_WhenSubtractingTwoNumbers_ResultEqualToSubtract()
    {
        // Act
        double result = _calculator.Subtract(20, 10);
        // Assert
        Assert.That(result, Is.EqualTo(10));
    }
    [Test]
    public void Multiply_WhenMultiplyTwoNumbers_ResultEqualToMultiply()
    {
        // Act
        double result = _calculator.Multiply(20, 10);
        // Assert
        Assert.That(result, Is.EqualTo(200));
    }
    [Test]
    public void Divide_WhenDivideTwoNumbers_ResultEqualToAnswer()
    {
        // Act
        double result = _calculator.Divide(20, 10);
        // Assert
        Assert.That(result, Is.EqualTo(2));
    }
    // [Test]
    // [TestCase(0, 0)]
    // [TestCase(0, 10)]
    // [TestCase(10, 0)]
    // public void Divide_WithZerosAsInputs_ResultThrowArgumentException(double a, double b)
    // {
    //     Assert.That(() => _calculator.Divide(a, b), Throws.ArgumentException);
    // }
    [Test]
    public void Factorial_WhenInputIsZero_ResultIsOne()
    {
        // Arrange
        int input = 0;

        // Act
        ulong result = _calculator.Factorial(input);

        // Assert
        Assert.That(result, Is.EqualTo(1));
    }
    [Test]
    public void AreaOfTriangle__WithPositivesAsInputs_ResultEqualToMultiplication()
    {
        // Act
        double result = _calculator.AreaOfTri(5, 5);
        // Assert
        Assert.That(result, Is.EqualTo(12.5));
    }
    [Test]
    [TestCase(0, 10)]
    [TestCase(-1, 10)]
    [TestCase(10, 0)]
    [TestCase(10, -1)]
    public void AreaOfTriangle_WithZerosAndNegativeAsInputs_ResultThrowArgumentException(double a, double b)
    {
        // Act and Assert
        Assert.That(() => _calculator.AreaOfTri(a, b), Throws.ArgumentException);
    }
    [Test]
    public void AreaOfCircle__WithPositivesAsInputs_ResultEqualToMultiplication()
    {
        // Act
        double result = _calculator.AreaOfCircle(8);
        // Assert
        Assert.That(result, Is.EqualTo(201.06));
    }
    [Test]
    [TestCase(0)]
    [TestCase(-1)]
    public void AreaOfCircle_WithZerosAndNegativeAsInputs_ResultThrowArgumentException(double a)
    {
        // Act and Assert
        Assert.That(() => _calculator.AreaOfCircle(a), Throws.ArgumentException);
    }
}