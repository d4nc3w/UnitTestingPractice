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

    [Test]
    public void TestMultiplyOperation()
    {
        Assert.That(_calculator.calculate(37, 5, '*'), Is.EqualTo(185));
    }

    [Test]
    public void TestDivideOperation()
    {
        Assert.That(_calculator.calculate(66, 6, '/'), Is.EqualTo(11));
        
        //Division by 0
        Assert.Throws<DivideByZeroException>(() => _calculator.calculate(66, 0, '/'));
    }

    [Test]
    public void TestUnsupportedOperation()
    {
        Assert.That(_calculator.calculate(5, 5, '&'), Is.EqualTo(10));
    }

    [Test]
    public void TestSignChange()
    {
        Assert.That(_calculator.calculate(5, 6, '-'), Is.LessThan(0));
        Assert.That(_calculator.calculate(-10, 6, '+'), Is.LessThan(0));
    }
}
