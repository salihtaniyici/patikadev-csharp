namespace exception_handling;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exception Handling");

        try
        {
            Console.WriteLine("Give me a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("I like that, Your number is " + number);
        }
        catch (System.Exception ex)
        {
            Console.WriteLine("Message: " + ex.Message.ToString());
        }
        finally 
        {
            Console.WriteLine("Successful");
        }

        try
        {
            Console.WriteLine("Format Exception");
            int b = int.Parse("error");
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex);
        }

        try
        {
            Console.WriteLine("Overflow Exception");
            int c = int.Parse("1234567891012");
        }
        catch (OverflowException ex)
        {
            Console.WriteLine(ex);
        }
    }
}
