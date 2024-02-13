using System;
using System.IO;
using System.Text.Json;

namespace Serialization_demo
{
    [Serializable]
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\serRsult\Sample.json";
            Employee emp = new Employee(21, "vysh");

            // Serialize object to JSON
            string jsonString = JsonSerializer.Serialize(emp);

            // Write JSON string to file
            File.WriteAllText(path, jsonString);

            Console.WriteLine("File created successfully");
            Console.ReadLine();
        }
    }
}

