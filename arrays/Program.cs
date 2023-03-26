namespace arrays;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Arrays");

        string[] colors = new string[3];
        string[] animals = new string[3]{"Cat","Dog","Monkey"};
        int[] numbers;
        numbers = new int[5];

        colors[0] = "Navy";
        numbers[2] = 8;

        Console.WriteLine(colors[0]);
        Console.WriteLine(numbers[2]);
        Console.WriteLine(animals[2]);

        // Average
        Console.WriteLine("How many numbers do you want to enter:");
        int arrayLength = int.Parse(Console.ReadLine());
        int[] numbersArray = new int[arrayLength];

        for (int i = 0; i < arrayLength; i++)
        {
            Console.WriteLine("Enter the {0}. element: ",i+1);
            numbersArray[i] = int.Parse(Console.ReadLine());
        }

        int sum = 0;
        foreach (var number in numbersArray)
        {
            sum += number;
        }

        Console.WriteLine("Average: "+ sum/arrayLength); 


    
    }
}
