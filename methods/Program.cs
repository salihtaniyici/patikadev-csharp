namespace methods;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Methods");
        Hello();

        int number01 = 7;
        int number02 = 8;

        int result01 = number01 + number02;
        Console.WriteLine(result01);

        int result02 = Sum(number01,number02);

        Methods methods = new Methods();
        methods.PrintResult(Convert.ToString(result02));

        int result03 = methods.AddandSum(ref number01,ref number02);
        methods.PrintResult(Convert.ToString(result03));

        int result04 = number01 + number02;
        methods.PrintResult(Convert.ToString(result04));

        void Hello(){
            Console.WriteLine("Hi! My name is Salih.");
        }



    }

    static int Sum(int a,int b){
        return a + b;
    }
}

class Methods{

    public void PrintResult(string resultData){
        Console.WriteLine(resultData);
    }

    public int AddandSum(ref int a,ref int b){

        a += 1;
        b += 3;
        return a + b;
    }
}