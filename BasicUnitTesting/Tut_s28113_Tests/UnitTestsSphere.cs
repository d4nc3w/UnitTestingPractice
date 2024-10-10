using BasicUnitTesting;

namespace Tut_s28113_Tests;

public class UnitTestsSphere
{
    private readonly IShape sphere = new Sphere(5);

    [Test]
    public void TestSphereCalculateArea()
    {
        Assert.That(sphere.CalculateArea(), Is.EqualTo(314.159).Within(0.001));
    }

    [Test]
    public void TestSphereCalculateVolume()
    {
        Assert.That(sphere.CalculateVolume(), Is.EqualTo(523.598).Within(0.001));
    }
}