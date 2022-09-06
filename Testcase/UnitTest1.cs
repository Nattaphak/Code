namespace Testcase;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        double number = Program.ConvertStringToDouble("1543.50");

        Assert.Equal(number, 1543.50);
    }
}