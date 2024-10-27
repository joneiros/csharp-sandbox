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
        String[] input = ["h","e","l","l","o"];
        String[] expected = ["o","l","l","e","h"];
        main.main(input);
        Assert.That(expected, Is.EqualTo(input));
    }

    [Test]
    public void Test2()
    {
        String[] input = ["H","a","n","n","a","h"];
        String[] expected = ["h","a","n","n","a","H"];
        main.main(input);
        Assert.That(expected, Is.EqualTo(input));
    }

    [Test]
    public void Test3()
    {
        String[] input = ["h","e","l","l","o"];
        String[] expected = ["o","l","l","e","h"];
        Assert.That(expected, Is.EqualTo(main.mainWithReturn(input)));
    }

    [Test]
    public void Test4()
    {
        String[] input = ["H","a","n","n","a","h"];
        String[] expected = ["h","a","n","n","a","H"];
        Assert.That(expected, Is.EqualTo(main.mainWithReturn(input)));
    }

    [Test]
    public void Test5()
    {
        String[] input = ["h","e","l","l","o"];
        char[] newInput = input.SelectMany(s => s.ToCharArray()).ToArray();
        char[] expected = ['o','l','l','e','h'];
        Assert.That(expected, Is.EqualTo(main.mainWithCharInput(newInput)));
    }

    //test of string to char coversion
    [Test]
    public void Test6()
    {
        String[] input = ["h","e","l","l","\u0041"];
        char[] expected = ['A','l','l','e','h'];
        char[] newInput = input.SelectMany(s => s.ToCharArray()).ToArray();
        Assert.That(expected, Is.EqualTo(main.mainWithCharInput(newInput)));
    }

    //test of char to string conversion(in method)
    [Test]
    public void Test7()
    {
        char[] input = ['h', 'e', 'l', 'l', 'o'];
        String[] expected = ["o", "l", "l", "e", "h"];
        Assert.That(expected, Is.EqualTo(main.mainWithCharInputAndStringOutput(input)));
    }
}