namespace TestDateFormat;

public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestWrongDate1()
    {
        const string input = "19/09/1999";
        const string expected = "1999-09-19";
        
        string actual = DateFormatter.ChangeFormat(input);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void TestWrongDate2()
    {
        const string input = "34/09/1999";
        const string expected = "";
        
        string actual = DateFormatter.ChangeFormat(input);
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void TestWrongDate3()
    {
        const string input = "";
        const string expected = "";
        
        string actual = DateFormatter.ChangeFormat(input);
        Assert.That(actual, Is.EqualTo(expected));
    }
}