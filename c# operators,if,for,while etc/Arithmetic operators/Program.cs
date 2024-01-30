using System;
    class Program
{
    static void Main(string[] args)
    {
        int result;
        int x = 10;
        int y=5;
        result = (x + y);
        Console.WriteLine("Arithmetic "+result);
        result = (x - y);
        Console.WriteLine( "sub"+result);
        result = (x * y);
        Console.WriteLine("multiplication " + result);
        result = (x/y);
        Console.WriteLine("division  " + result);
        result = (x%y);
        Console.WriteLine("mod " + result);
        Console.ReadLine();
    }
}