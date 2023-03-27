namespace recursive_extension_methods;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Recursive, Extension Methods");

        int number = 5;
        int result = 1;
        // 5*5*5*5
        for (int i = 1; i < 5; i++)
        {
            result *= number;
        }
        Console.WriteLine(result);


        RecursiveFunc recursiveFunc = new();
        Console.WriteLine(recursiveFunc.Exp(2,5));

        string text = "Ne demişler, vazgeçmek yok yola devam!";
        bool sonuc = text.CheckSpaces();
        Console.WriteLine(sonuc);
        Console.WriteLine(text.RemoveSpaces());
        Console.WriteLine(text.UpperCase());
        Console.WriteLine(text.LowerCase());

        int[] numbers = {9,5,4,7,2,11,0};
        numbers.SortArray();
        numbers.Print();

        Console.WriteLine(number.isEven());

        Console.WriteLine(text.GetFirst());

    }
}

static class ExtensionFunc{

    public static bool CheckSpaces(this string param)
    {
        return param.Contains(" ");
    }

    public static string RemoveSpaces(this string param)
    {
        string[] newText = param.Split(" ");
        return string.Join("",newText);
    }

    public static string UpperCase(this string param)
    {
        return param.ToUpper();
    }
    public static string LowerCase(this string param)
    {
        return param.ToLower();
    }

    public static int[] SortArray(this int[] param)
    {
       Array.Sort(param);
       return param;
    }

    public static void Print(this int[] param)
    {
        foreach (var item in param)
        {
            Console.WriteLine(item);
        }

    } 

    public static bool isEven(this int param)
    {
        return param % 2 == 0;
    }

    public static string GetFirst(this string param)
    {
        return param.Substring(0,1);
    }


}

class RecursiveFunc{

    public int Exp(int num,int ex){

        if (ex < 2)
        {
            return num;
        }
        return Exp(num , ex - 1) * num;
    }

    // called Exp(2,5)

    // Exp(2,4) * 2
    // Exp(2,3) * 2 * 2
    // Exp(2,2) * 2 * 2 * 2
    // Exp(2,1) * 2 * 2 * 2 * 2
    // ex < 2 => 2 * 2 * 2 * 2 * 2
}
