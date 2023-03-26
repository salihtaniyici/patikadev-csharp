namespace if_else_ternary;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("If else ternary");
        
        int time = DateTime.Now.Hour;
        int day = DateTime.Now.Day;

        if (time >= 8 && time <= 12)
            Console.WriteLine("Bonjour!");
        else if (time > 12 && time <= 17)
        {
            Console.WriteLine("Bonne journee!");
        }
        else
        {
            Console.WriteLine("Bonne nuit!");
        }

        string jour = day == 26 ? "dimanche" : "lundi";
        // string jour = day == 26 ? "dimanche" : day == 27 ? "lundi" : "mardi";
        Console.WriteLine(jour);

        

    }
}
