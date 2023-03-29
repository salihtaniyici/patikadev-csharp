namespace algorithm_task;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Task 1");
        Console.WriteLine("Pozitif bir sayi giriniz: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{number} adet pozitif sayi giriniz: ");
        int[] numbers = new int[number];
        for (int i = 0; i < number; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Girmis oldugunuz cift sayilar asagida listelenmistir..");
        foreach (var item in numbers)
        {
            if(item % 2 == 0)
            {
                Console.WriteLine(item);
            }
            
        }

        Console.WriteLine("Task 2");
        Console.WriteLine("Pozitif iki sayi giriniz: ");
        Console.WriteLine("İlk sayiyi giriniz: ");
        int n =  Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("İkinci sayiyi giriniz: ");
        int m =  Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{n} adet pozitif sayi giriniz: ");
        int[] narr = new int[n];
        for (int i = 0; i < n; i++)
        {
            narr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Girmis oldugunuz sayilardan ikinci sayiya bolunebilen ya da esit olan sayilar asagida listelenmistir..");
        foreach (var item in narr)
        {
            if(item % m == 0 || item == m)
            {
                Console.WriteLine(item);
            }
            
        }

        Console.WriteLine("Task 3");
        Console.WriteLine("Pozitif bir sayi giriniz: ");
        int nu = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{nu} adet kelime giriniz: ");
        string[] inputs = new string[nu];
        for (int i = 0; i < nu; i++)
        {
            inputs[i] = Console.ReadLine();
        }
        Console.WriteLine("Kelimelerin tersten okunusu: ");
        for (int i = inputs.Length - 1 ; i >= 0; i--)
        {
            Console.WriteLine(inputs[i]);
        }

        Console.WriteLine("Task 4");
        Console.WriteLine("Bir cümle yaziniz: ");
        string text = Console.ReadLine();
        string[] texts = text.Split(' ');
        Console.WriteLine($"Toplam kelime sayisi: {texts.Length}");
        Console.WriteLine($"Toplam harf sayisi: {text.Length}");



    }
}
