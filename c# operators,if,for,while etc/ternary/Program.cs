class Program
{

    static void Main(string[] args)
    {
        int x = 5, y = 10, result;

        
        result = x > y ? x : y;
        
        //it is like if-else statement
        //if first condition is true then first statetment is printed
        //else the second statement is printed
        
        Console.WriteLine("Result: " + result);

       
        result = x < y ? x : y;

       
        Console.WriteLine("Result: " + result);
    }
}

