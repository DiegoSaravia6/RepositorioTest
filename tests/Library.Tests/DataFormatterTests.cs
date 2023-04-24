namespace Library.Tests;

public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        const string input = "19-09-1999";
        const string expect = "19-09-1999";
        
        Assert.pass();
    }

    [Test]
    public void Test2()
    {
        const string input = "19/09/1999";
        const string expect = "19-09-1999";

        Assert.pass();
    }

    [Test]
    public void Test3()
    {
        const string input = "";
        const string expect = "";

        Assert.pass();
    }
}