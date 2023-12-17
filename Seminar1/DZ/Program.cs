using static DZ.Calc;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine(Calculate(args));
        }
        catch (ArgumentException argEx) 
        {
            Console.WriteLine(argEx.Message);
        }
        catch (FormatException argEx) 
        { 
            Console.WriteLine(argEx.Message);
        }
        catch (DivideByZeroException argEx)
        {
            Console.WriteLine(argEx.Message);
        }


    }
}