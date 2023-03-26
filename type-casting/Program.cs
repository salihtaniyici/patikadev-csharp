namespace type_casting;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Type casting!");

        // Implicit Casting
        // char -> int -> long -> float -> double

        Console.WriteLine("Implicit Casting");
        int a = 18;
        long b = 24;
        float c;
        c = b;
        Console.WriteLine(c);

        // Explicit Casting
        Console.WriteLine("Explicits Casting");
        float d = 14.8f;
        long e = (long)d;
        Console.WriteLine(e);


        // Type Conversion Methods
        Console.WriteLine("Type Conversion Methods");
        string f = "24";
        double g = 19.87;
        int num01 = Convert.ToInt32(f);
        int num02 = Convert.ToInt32(g);

        int result = num01 + num02;
        Console.WriteLine(result);

        // Parse
        Console.WriteLine("Parse");

        string code = "15689413";
        int intCode = Int32.Parse(code);
        Console.WriteLine(intCode);

    }
}
