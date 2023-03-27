using System.Collections;

namespace arraylist;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Arraylist");

        ArrayList colors = new ArrayList();

        colors.Add("Navy");
        colors.Add("Orange");
        colors.Add("Yellow");
        colors.Add("Gray");

        Console.WriteLine(colors[0]);

        foreach (var color in colors)
        {
            Console.WriteLine(color);
        }

        //AddRange
        Console.WriteLine(" **AddRange");

        string[] animals = new string[]{"Monkey","Cat","Dog"};
        List<int> numbers = new List<int>(){0,9,84,65,12,8,7};

        //colors.AddRange(animals);
        //colors.AddRange(numbers);

        
        // Sort
        Console.WriteLine(" **Sort");
        colors.Sort();
        foreach (var color in colors)
        {
            Console.WriteLine(color);
        }

        // BinarySearch
        Console.WriteLine(" **BinarySearch");
        Console.WriteLine(colors.BinarySearch("Navy"));

        // Reverse
        Console.WriteLine(" **Reverse");
        colors.Reverse();
        foreach (var color in colors)
        {
            Console.WriteLine(color);
        }

        // Clear
        Console.WriteLine(" **Clear");
        colors.Clear();
        foreach (var color in colors)
        {
            Console.WriteLine(color);
        }





        


    










    }
}
