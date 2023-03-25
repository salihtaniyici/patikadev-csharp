namespace operators;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Operators!");

        // Arithmetic (+, -, *, /, %, ++, --)
        Console.WriteLine("Arithmetic (+, -, *, /, %, ++, --)");
        int number01 = 38;
        int number02 = 22;
        int number03 = 2;
        int number04 = 5;
        int result = number01 + number02;
        Console.WriteLine(result);
        result = number01 - number02;
        Console.WriteLine(result);
        result = number01 * number02;
        Console.WriteLine(result);
        result = number01 / number03;
        Console.WriteLine(result);
        result = number01 % number02;
        Console.WriteLine(result);
        number04++;
        Console.WriteLine(number04);
        number04--;
        Console.WriteLine(number04);

        // Assignment (=, +=, -=, *=, /=,)
        Console.WriteLine("Assignment (=, +=, -=, *=, /=,)");
        int number05 = 8;
        number05 += 3;
        Console.WriteLine(number05);
        number05 -= 2;
        Console.WriteLine(number05);
        number05 *= 2;
        Console.WriteLine(number05);
        number05 /= 3;
        Console.WriteLine(number05);
        
        // Logical (&&, ||, !)
        Console.WriteLine("Logical (&&, ||, !)");
        bool answer01 = true;
        bool answer02 = false;

        if (answer01 && answer02)
            Console.WriteLine("You are wrong!");
        if (answer01 || answer02)
            Console.WriteLine("You are correct!");
        if (answer01 || !answer02)
            Console.WriteLine("You are quite right!");
        
        // Comparison (==, <=, >=, !=)
        Console.WriteLine(" Comparison (==, <=, >=, !=)");
        int number06 = 13;
        int number07 = 19;
        bool check = number06 == number07;
        Console.WriteLine(check);
        check = number06 <= number07;
        Console.WriteLine(check);
        check = number06 >= number07;
        Console.WriteLine(check);
        check = number06 != number07;
        Console.WriteLine(check);

    }
}
