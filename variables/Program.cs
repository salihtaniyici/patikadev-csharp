namespace variables;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Variables!");


        string caseSensitive = " ";
        string CaseSensitive = string.Empty;
        int camilCase = 37;


        // 1 byte = 8 bit 


        string name = "Salih"; // represents text as a sequence of UTF-16 code units.
        string surname = "Taniyici";
        string fullName = name + " " + surname;
        string str = null;
        char n = 'S'; // 2 byte
        char s = 'T';
        
        // integer
        
        byte b = 2;  // represents an 8-bit unsigned integer.
        sbyte sb = 2; // 1 byte
        
        short sh = 3; // 2 byte
        ushort us = 3; // 2 byte

        
        Int16 i16 = 4; // 2 byte
        int i = 4; // 4 byte
        Int32 i32 = 4; // 4 byte
        Int64 i64 = 4; // 8 byte
        uint ui = 4; // 4 byte
        int sums = i16 * i32;

        long l = 5 ;
        ulong ul = 5;

        //  floating-point number

        float f = 6f;
        double d = 7d;
        decimal dc = 8;

        bool completed = true;
        bool compare = 24 > 46;

        DateTime dt = DateTime.Now;
        string datetime = DateTime.Now.ToString("dd.MM.yyyy");
        string hour = DateTime.Now.ToString("HH:mm");
        Console.WriteLine(dt);
        Console.WriteLine(datetime);
        Console.WriteLine(hour);

        //  object: it is  the root of the type hierarchy.

        object stringObj = "A";
        object charObj = 'B';
        object intObj = 24;
        object floatObj = 14.10f;

        // type conversion

        int willString = 2023;
        string willInt = "2503";
        
        int result = willString + Convert.ToInt32(willInt);
        string today = willInt + willString.ToString();

        Console.WriteLine(result);
        Console.WriteLine(today);

        int dm = int.Parse(willInt);

    }
}
