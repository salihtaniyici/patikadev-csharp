namespace method_overloading;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Method overloading");

        // OUT parameter

        string number = "159";

        bool result = int.TryParse(number,out int num);

        if (result)
        {
            Console.WriteLine(num);
        }
        else
        {
            Console.WriteLine("ERROR!!");
        }

        OutParameter outParameter = new OutParameter();
        outParameter.Sum(4,5,out int toplam);

        MethodOverload methodOverload = new MethodOverload();
        methodOverload.PrintData(23);
        methodOverload.PrintData("Hello!");
        methodOverload.PrintData("Hello, World!");


    }
}

class OutParameter{

    public void Sum(int a, int b, out int toplam)
    {
        toplam = a + b;
        Console.WriteLine(toplam);
    }


}

class MethodOverload{

    public void PrintData(string data)
    {
        Console.WriteLine(data);
    }

    public void PrintData(int data)
    {
        Console.WriteLine(data);
    }

    public void PrintData(string data1 , string data2)
    {
        Console.WriteLine( data1 + data2 );
        ;
    }

}
