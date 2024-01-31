using System;
class Program
{

    static void displayNamed(string name, int age, string branch)
    {
        Console.WriteLine($"Name: {name}, Age: {age}, Branch: {branch}");
    }
    static void displayoptional(string name, int age = 25, string city = "DefaultCity")
    {
        Console.WriteLine($"Name: {name}, Age: {age}, City: {city}");
    }



    static void Main(string[] args)
    {
          displayNamed(age: 21, name: "vysh", branch: "cse");
           displayoptional("vysh");

    }
}