namespace dictionary;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dictionary");
        Dictionary<int,string> cities = new Dictionary<int, string>();
        
        cities.Add(1,"Adana");
        cities.Add(31,"Hatay");
        cities.Add(63,"Sanliurfa");
        cities.Add(6,"Ankara");

        Console.WriteLine(cities[1]);
        foreach (var city in cities)
        {
            Console.WriteLine(city);
        }

        //Count
        Console.WriteLine("Count");
        Console.WriteLine(cities.Count);

        //Contains
        Console.WriteLine("Contains");
        Console.WriteLine(cities.ContainsKey(1));
        Console.WriteLine(cities.ContainsValue("Istanbul"));

        //Remove
        Console.WriteLine("Remove");
        cities.Remove(63);

        //Keys
        Console.WriteLine("Keys");
        foreach (var city in cities.Keys)
        {
            Console.WriteLine(city);
        }

        //Values
        Console.WriteLine("Values");
        foreach (var city in cities)
        {
            Console.WriteLine(city.Value);
        }
    }
}
