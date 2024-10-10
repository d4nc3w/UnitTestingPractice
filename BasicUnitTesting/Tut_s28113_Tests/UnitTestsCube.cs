using BasicUnitTesting;

namespace Tut_s28113_Tests;

public class UnitTestsCube
{
    private readonly IShape cube = new Cube(5);

    [Test]
    public void TestCubeCalculateArea()
    {
        Assert.That(cube.CalculateArea(), Is.EqualTo(150));
    }

    [Test]
    public void TestCubeCalculateVolume()
    {
        Assert.That(cube.CalculateVolume(), Is.EqualTo(125));
    }
}