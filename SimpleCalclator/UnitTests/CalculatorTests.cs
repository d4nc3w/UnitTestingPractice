using SimpleCalclator;

namespace UnitTests;

public class Tests
{
    private Calculator _calculator;

    [SetUp]
    public void Setup()
    {
        _calculator = new Calculator();
    }

    [Test]
    public void TestAddOperation()
    {
        Assert.That(_calculator.calculate(5, 5, '+'), Is.EqualTo(10));
    }

    [Test]
    public void TestSubtractOperation()
    {
        Assert.That(_calculator.calculate(100, 75, '-'), Is.EqualTo(25));
    }
}
