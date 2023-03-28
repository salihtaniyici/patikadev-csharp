namespace class_constructor;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("AUTO SHOWROOM");

        Car car01 = new Car();
        car01.Id = 1;
        car01.Brand = "McLaren P1";
        car01.Price = 11651919;

        car01.GetInfo();

        Car car02 = new Car(2,"Lamborghini",298495613);
        
        car02.GetInfo();

    }
}

class Car{

    int id ;
    string brand ;
    int price ;

    public int Id { get => id; set => id = value; }
    public string Brand { get => brand; set => brand = value; }
    public int Price { get => price; set => price = value; }

    public Car()
    {
    }

    public Car(int id, string brand, int price)
    {
        this.Id = id;
        this.Brand = brand;
        this.Price = price;
    }

    public void GetInfo()
    {
        Console.WriteLine("Car ID: {0}",Id);
        Console.WriteLine("Car Brand: {0}",Brand);
        Console.WriteLine("Car Price: {0}",Price);
    }

    
}
