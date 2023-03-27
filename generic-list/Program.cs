namespace generic_list;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Generic-List");
        
        List<string> animals = new List<string>();
        animals.Add("Bear");
        animals.Add("Monkey");
        animals.Add("Bird");
        animals.Add("Lion");


        List<int> numbers = new List<int>();
        numbers.Add(3);
        numbers.Add(5);
        numbers.Add(7);
        numbers.Add(9);
        numbers.Add(13);


        foreach (var animal in animals)
        {
            Console.WriteLine(animal);
        }

        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("Animal List:");
        animals.ForEach(animal => Console.WriteLine(animal));

        Console.WriteLine("Number List:");
        numbers.ForEach(number => Console.WriteLine(number));

        // Count
        Console.WriteLine(animals.Count);
        Console.WriteLine(numbers.Count);


        // Remove, RemoveAt
        animals.Remove("Bear");
        numbers.Remove(3);
        animals.RemoveAt(1);
        numbers.RemoveAt(0);

        Console.WriteLine("Animal List:");
        animals.ForEach(animal => Console.WriteLine(animal));

        Console.WriteLine("Number List:");
        numbers.ForEach(number => Console.WriteLine(number));

        // Contains
        if (animals.Contains("Monkey"))
        {
            Console.WriteLine("Maymunluk yapmasana");
        }

        // BinarySearch
        Console.WriteLine(numbers.BinarySearch(13));


        // Array to List
        string[] colors = {"Yellow","Blue","Orange"};
        List<string> couleurs = new List<string>(colors);

        
        couleurs.ForEach(couleur => Console.WriteLine(couleur));

        // Clear
        couleurs.Clear();

        List<User> users = new List<User>();
        User user01 = new User();
        user01.Id = 1;
        user01.Username = "salihtaniyici";

        User user02 = new User();
        user02.Id = 2;
        user02.Username = "salihtaniyic";

        users.Add(user01);
        users.Add(user02);

        foreach (var user in users)
        {
            Console.WriteLine(user.Id);
            Console.WriteLine(user.Username);

        }

        List<User> privateusers = new List<User>();

        privateusers.Add(new User(){
            Id = 3,
            Username = "privateuser"
        }
        );

        privateusers.ForEach(privateuser => Console.WriteLine(privateuser.Username));




    }
}

class User{

    private int id;
    private string username;

    public int Id { get => id; set => id = value; }
    public string Username { get => username; set => username = value; }
}
