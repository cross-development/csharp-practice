using Sources.Methods;

namespace BasicUnitTests;

public class UnitTest1
{
    [Fact]
    public void TestDividingTwoNumbersCorrect()
    {
        int a = 10;
        int b = 2;
        int expected = 5;

        int actual = MethodsPractice.DivideTwoNumbers(a, b);
        
        Assert.Equal(expected, actual);
    }
}