public class Program
{
    public static string InputName()
    {
        Console.Write("Please input Name: ");

        return Console.ReadLine();
    }

    public static string InputOwner()
    {
        Console.Write("Please input Owner name: ");

        return Console.ReadLine();
    }


    public static long InputNumber()
    {
        Console.Write("Please input Number:");

        return long.Parse(Console.ReadLine());
    }


    public static long InputValue()
    {
        Console.Write("Please input Registered Value: ");

        return long.Parse(Console.ReadLine());
    }

    public static string InputMoney()
    {
        Console.Write("Please Input Money :");

        return Console.ReadLine();
    }
    
    public static double ConvertStringToDouble(string value)
    {
        if (double.TryParse(value, out double number))
        {
            return number;
        }

        throw new Exception("Please input your money info!!!.");
    }

    static void Main(string[] args)
    {
        string name = InputName();     
        long number = InputNumber();   

        string owner = InputOwner();   

        long value = InputValue();   

        Info info = new Info();

        info.PrintInformation(name, number, owner, value);  

        string baht = InputMoney();

        double tang = ConvertStringToDouble(baht);

        Money money = new Money();

        money.Calculator(tang);

    }

}