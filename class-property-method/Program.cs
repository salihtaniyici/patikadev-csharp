namespace class_property_method;
class Program
{
    static void Main(string[] args)
    {

        User user01 = new User();
        user01.Id = 1;
        user01.Username = "salihtaniyici";
        user01.Password = 123456;

        user01.GetInfo();

        User user02 = new User(2,"salihtaniyic",78912345);

        user02.GetInfo();


    }
}

class User{

    int id ;
    string username ;
    int password;

    public int Id { get => id; set => id = value; }
    public string Username { get => username; set => username = value; }
    public int Password { get => password; set => password = value; }

    public User()
    {
    }

    public User(int id, string username, int password)
    {
        this.Id = id;
        this.Username = username;
        this.Password = password;
      
    }

    public void GetInfo()
    {
        Console.WriteLine("ID: " + Id );
        Console.WriteLine("Username: " + Username );
        Console.WriteLine("Password: " + Password );
    }
}
