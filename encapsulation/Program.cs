namespace encapsulation;
class Program
{
    static void Main(string[] args)
    {
        Boxer boxer = new Boxer();
        boxer.Id = 1;
        boxer.Name = "Muhammed Ali";
        boxer.Power = 900;

        boxer.GetInfo();

        boxer.PowerDown();
        boxer.GetInfo();

        boxer.PowerUp();
        boxer.PowerUp();
        boxer.GetInfo();
        boxer.PowerUp();
        boxer.PowerUp();
        boxer.GetInfo();
        
    }
}

class Boxer{

    int id;
    string name;
    int power;

    public int Id { get => id; set => id = value; }
    public string Name { get => name; set => name = value; }
    public int Power 
    {  
        get {return power;}

        set {   
                if (value >= 1000)
                {
                    power = 1000;
                    Console.WriteLine("Maximum power reached!");
                    
                }
                else 
                    power = value;
            } 
    }

    public Boxer()
    {
    }

    public Boxer(int id, string name, int power)
    {
        this.Id = id;
        this.Name = name;
        this.Power = power;
      
    }

    public void PowerUp(){
        this.Power += 50;
    }

    public void PowerDown(){
        this.Power -= 50;
    }

    public void GetInfo()
    {
        Console.WriteLine("Boxer: ");
        Console.WriteLine("Boxer ID: {0}", Id);
        Console.WriteLine("Boxer Name: {0}", Name);
        Console.WriteLine("Boxer Power: {0}", Power);
    }
}
