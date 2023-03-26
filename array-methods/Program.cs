namespace array_methods;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" ** Array methods");
        
        int[] numbers = {25,6,13,9,2};
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine(" ** Array methods - Sort");
        
        Array.Sort(numbers);
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine(" ** Array methods - Clear");

        Array.Clear(numbers,2,2);
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine(" ** Array methods - Reverse");
        
        Array.Reverse(numbers);
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine(" ** Array methods - Resize");

        Array.Resize<int>(ref numbers,6);
        numbers[5] = 99;
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine(" ** Array methods - IndexOf");
        Console.WriteLine(Array.IndexOf(numbers,13));
        
    }
}
