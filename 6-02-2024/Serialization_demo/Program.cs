using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

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
            string path = @"C:\serRsult\Sample.txt";
            Employee emp = new Employee(21, "vysh");
            using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate)) 
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(stream, emp);
                Console.WriteLine("File created successfully");
            }

            /*Employee obj = (Employee)bF.Deserialize(stream);
            Console.WriteLine(obj.Empid);
            Console.WriteLine(obj.Name);
            Console.ReadLine();*/

        }
    }
}
