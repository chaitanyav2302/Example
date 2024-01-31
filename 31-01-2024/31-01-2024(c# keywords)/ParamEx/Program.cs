using System;
 class Program
{
    static void display(params object[] data)
    {
        foreach(object o in data)
        {
            Console.WriteLine(o.ToString());
        }
    }
    static void displayInt(params int[] data1)
    {
        foreach (int i in data1)
        {
            Console.WriteLine(i);
        }
    }
    static void displayString(params string[] data2)
    {
        foreach(string str in data2)
        {
            Console.WriteLine(str);
        }
    }




    static void Main(string[] args)
    {
        display(1, "vysh", "EPAM", 21);
        displayInt(1, 2, 3, 4, 5);
        displayString("paris", "london", "europe");
    }

}
