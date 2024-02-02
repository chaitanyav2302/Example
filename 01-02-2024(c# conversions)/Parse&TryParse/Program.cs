using System;
class Program
{
    static void Main(string[] args)
    {
        string i = String.Empty;
        try
        {
            int res = int.Parse(i);
            Console.WriteLine(res);
        }
        catch (FormatException)
        {
            Console.WriteLine($"Unable to parse '{i}'");
        }

        String s = "102";
        if(int.TryParse(s, out int z))
        {
            Console.WriteLine("parsed successfully");
        }
        Console.WriteLine(z);
         







    }
}