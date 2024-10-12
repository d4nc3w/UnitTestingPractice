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
        //False
        Assert.That(_calculator.calculate(5, 5, '+'), Is.EqualTo(5));
    }

    [Test]
    public void TestSubtractOperation()
    {
        Assert.That(_calculator.calculate(100, 75, '-'), Is.EqualTo(25));
        //False
        Assert.That(_calculator.calculate(100, 75, '-'), Is.EqualTo(50));
    }

    [Test]
    public void TestMultiplyOperation()
    {
        Assert.That(_calculator.calculate(37, 5, '*'), Is.EqualTo(185));
        //False
        Assert.That(_calculator.calculate(37, 5, '*'), Is.EqualTo(190));
    }

    [Test]
    public void TestDivideOperation()
    {
        Assert.That(_calculator.calculate(66, 6, '/'), Is.EqualTo(11));
        //False
        Assert.That(_calculator.calculate(10, 0, '/'), Is.EqualTo(0));
    }
}
