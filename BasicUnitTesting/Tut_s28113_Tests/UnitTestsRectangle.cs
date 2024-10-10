using BasicUnitTesting;

namespace Tut_s28113_Tests;

public class UnitTestsRectangle
{
    private readonly IShape rectangle = new Rectangle(10, 5);

    [Test]
    public void TestRectangleCalculateArea()
    {
        Assert.That(rectangle.CalculateArea(), Is.EqualTo(50));
    }

    [Test]
    public void TestRectangleCalculateVolume()
    {
        Assert.That(rectangle.CalculateVolume(), Is.EqualTo(0));
    }
}