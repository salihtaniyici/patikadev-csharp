namespace while_foreach;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("While");
        Console.Write("Give me a number: ");
        int limit = int.Parse(Console.ReadLine());
        int sum = 0;
        int number = 1;
        while (number <= limit)
        {
            sum += number;
            number++;
        }
        Console.WriteLine("Sum: " + sum);

        Console.WriteLine("Foreach");
        string[] nationality = {"Turkey","France","England"};
        foreach (var nat in nationality)
        {
            Console.WriteLine(nat);
        }
    }
}
