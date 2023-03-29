namespace enums;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Day.Saturday);
        Console.WriteLine((int)Day.Thursday);

        int input = 12;

        if (input == (int)Player.Idle)
        {
            Console.WriteLine("Player IDLE");
        }

        if (input == (int)Player.Walk)
        {
            Console.WriteLine("Player WALK");
        }

        if (input == (int)Player.Jump)
        {
            Console.WriteLine("Player JUMP");
        }

        if (input == (int)Player.Attack)
        {
            Console.WriteLine("Player ATTACK");
        }
    }
}

enum Day
{
    Monday,
    Tuesday,
    Wednesday = 7,
    Thursday,
    Friday = 23,
    Saturday,
    Sunday

}

enum Player
{
    Idle = 2,
    Walk = 6,
    Jump = 9,
    Attack = 12

}
