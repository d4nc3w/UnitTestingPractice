using BasicUnitTesting;

namespace Tut_s28113_Tests;

public class UnitTestsCylinder
{
    private readonly IShape cylinder = new Cylinder(5, 10);

    [Test]
    public void TestCylinderCalculateArea()
    {
        Assert.That(cylinder.CalculateArea(), Is.EqualTo(471.2).Within(0.1));
    }

    [Test]
    public void TestCylinderCalculateVolume()
    {
        Assert.That(cylinder.CalculateVolume(), Is.EqualTo(785.3).Within(0.1));
    }
}