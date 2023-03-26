namespace forloop_break_continue;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("For loop, break, continue");

        Console.WriteLine("Give me a number:");
        int number = int.Parse(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Even numbers:");
        for (int i = 2; i <= number; i++)
        {
            if (number >= 2 && i % 2 == 0 )
            {
                Console.WriteLine(i);
            }
        }
        Console.WriteLine("Odd numbers:");
        for (int i = 1; i <= number; i++)
        {
            if (number >= 1 && i % 2 == 1 )
            {
                Console.WriteLine(i);
            }
        }

        Console.WriteLine("Break:");
        for (int i = 0; i < number; i++)
        {
            if (i == 4)
            {
                break;
            }
            Console.WriteLine(i);
            
        }

        Console.WriteLine("Continue:");
        for (int i = 0; i < number; i++)
        {
            if (i == 4)
            {
                continue;
            }
            Console.WriteLine(i);
            
        }

        
    }
}
