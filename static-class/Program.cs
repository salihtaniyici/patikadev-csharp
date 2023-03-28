namespace static_class;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Player ID: {0}",Player.Id);

        Player player01 = new Player("Salih","C#");
        Console.WriteLine("Player ID: {0}",Player.Id);
        Player player02 = new Player("X","C#");
        Console.WriteLine("Player ID: {0}",Player.Id);
        Player player03 = new Player("Y","C#");
        Console.WriteLine("Player ID: {0}",Player.Id);

        Console.WriteLine(Calculator.Sum(100,2));
        Console.WriteLine(Calculator.Multiplication(5,9));
    }
}

class Player
{

    static int id;

    string name;
    string team;

    public static int Id { get => id;}

    static Player()
    {
        id = 0;
    }

    public Player(string name,string team)
    {
        this.name = name;
        this.team = team;
        id++;
    }
}

static class Calculator
{

    public static long Sum(int number01,int number02)
    {
        return number01 + number02;
    }

    public static long Multiplication(int number01,int number02)
    {
        return number01 * number02;
    }


}
