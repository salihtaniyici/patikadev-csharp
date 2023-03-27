namespace string_methods;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("String methods");

        string text01 = "Simdi degilse ne zaman?";
        string text02 = "simdi degilse ne zaman?";
        string comic = "Bekliyorum ben hala o zaman.";

        // Length;
        Console.WriteLine(text01.Length);

        // ToUpper, ToLower
        Console.WriteLine(text01.ToUpper());
        Console.WriteLine(text01.ToLower());

        // Concat
        Console.WriteLine(text01 + " Belki de yakindir.");

        // Compare, CompareTo
        Console.WriteLine(String.Compare(text01,text02,true));
        Console.WriteLine(String.Compare(text01,text02,false));
        Console.WriteLine(text01.CompareTo(text02));

        // Contains
        Console.WriteLine(text01.Contains("ne"));

        // EndsWith, StartsWith
        Console.WriteLine(text01.StartsWith("Si"));
        Console.WriteLine(text01.EndsWith("an"));

        // IndexOf, LastIndexOf
        Console.WriteLine(text01.IndexOf("ne"));
        Console.WriteLine(text01.LastIndexOf("ne"));

        // Insert
        Console.WriteLine(text01.Insert(0,"Hey! "));

        // PadLeft, PadRight
        Console.WriteLine(text01 + comic.PadLeft(5,'*'));
        Console.WriteLine(text01.PadRight(8,'-') + comic);

        // Remove
        Console.WriteLine(text01.Remove(5));
        Console.WriteLine(text01.Remove(3,6));
        Console.WriteLine(text01.Remove(0,1));

        // Replace
        Console.WriteLine(comic.Replace("Bekliyorum","Beklemiyorum"));


        // Split
        Console.WriteLine(text01.Split(" ")[1]);

        // Substring
        Console.WriteLine(text01.Substring(7));
        Console.WriteLine(text01.Substring(2,9));





    }
}
