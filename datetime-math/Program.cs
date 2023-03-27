﻿namespace datetime_math;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("DateTime");

        Console.WriteLine(DateTime.Now);
        Console.WriteLine(DateTime.Now.Date);
        Console.WriteLine(DateTime.Now.Day);
        Console.WriteLine(DateTime.Now.Month);
        Console.WriteLine(DateTime.Now.Year);
        Console.WriteLine(DateTime.Now.Hour);
        Console.WriteLine(DateTime.Now.Minute);
        Console.WriteLine(DateTime.Now.Second);

        Console.WriteLine(DateTime.Now.DayOfWeek);
        Console.WriteLine(DateTime.Now.DayOfYear);

        Console.WriteLine(DateTime.Now.ToLongDateString());
        Console.WriteLine(DateTime.Now.ToShortDateString());

        Console.WriteLine(DateTime.Now.ToLongTimeString());
        Console.WriteLine(DateTime.Now.ToShortTimeString());

        Console.WriteLine(DateTime.Now.AddDays(2));
        Console.WriteLine(DateTime.Now.AddMonths(3));
        Console.WriteLine(DateTime.Now.AddYears(9));
        Console.WriteLine(DateTime.Now.AddHours(2));
        Console.WriteLine(DateTime.Now.AddMinutes(15));
        Console.WriteLine(DateTime.Now.AddSeconds(30));

        // DateTime Format
        Console.WriteLine(DateTime.Now.ToString("dd"));
        Console.WriteLine(DateTime.Now.ToString("ddd"));
        Console.WriteLine(DateTime.Now.ToString("dddd"));

        Console.WriteLine(DateTime.Now.ToString("MM"));
        Console.WriteLine(DateTime.Now.ToString("MMM"));
        Console.WriteLine(DateTime.Now.ToString("MMMM"));

        Console.WriteLine(DateTime.Now.ToString("yy"));
        Console.WriteLine(DateTime.Now.ToString("yyyy"));

        Console.WriteLine("Math");

        Console.WriteLine(Math.Abs(-24));
        Console.WriteLine(Math.Pow(2,5));
        Console.WriteLine(Math.Sqrt(36));
        Console.WriteLine(Math.Sin(90));
        Console.WriteLine(Math.Cos(90));
        Console.WriteLine(Math.Tan(90));
        Console.WriteLine(Math.Max(3,5));
        Console.WriteLine(Math.Min(3,5));
        Console.WriteLine(Math.Ceiling(3.7));
        Console.WriteLine(Math.Round(2.7));
        Console.WriteLine(Math.Round(2.5));
        Console.WriteLine(Math.Round(2.3));
        Console.WriteLine(Math.Floor(3.7));

        Console.WriteLine(Math.Log(10));
        Console.WriteLine(Math.Log10(20));
        Console.WriteLine(Math.Exp(3));
        Console.WriteLine(Math.PI);


    }
}
