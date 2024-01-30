// C# program to illustrate 
// switch case statement 
using System;

class Program
{
     static void Main(String[] args)
    {
        int i = int.Parse(Console.ReadLine());
        int x = 10, y = 5;
        bool res;
        switch (i)
        {

            case 1:
                 res = (x == y);
                Console.WriteLine(res);

                break;
            case 2:
                 res = (x > y);
                Console.WriteLine(res);
                break;
            case 3:
                res = (x < y);
                Console.WriteLine(res);
                break;
            case 4:
                res = (x <= y);
                Console.WriteLine(res);
                break;
            case 5:
                res = (x >= y);
                Console.WriteLine(res);
                break;

            default:
                Console.WriteLine("No match found");
                break;
        }
    }
}
