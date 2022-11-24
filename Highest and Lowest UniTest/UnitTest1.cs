namespace Highest_and_Lowest_UniTest;
using NUnit.Framework;
using Highest_and_Lowest;


public class Tests
{
    
    [TestCase("0 -3 -9 -199")]
    public void Test1(string data)
    {
        Assert.AreEqual("0 -199", HighsetAndLowest.HighAndLow(data));
    }
}