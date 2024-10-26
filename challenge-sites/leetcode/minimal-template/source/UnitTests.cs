namespace minimal_template;

public class Tests
{
    Main main;


    [SetUp]
    public void Setup()
    {
        main = new Main();
    }

    [Test]
    public void Test1()
    {
        Assert.IsTrue(main.main());
    }

    [Test]
    public void Test2()
    {
        Assert.IsTrue(main.main());
    }
}