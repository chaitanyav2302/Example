using System;
using System.IO;
using System.Xml.Serialization;

namespace Serialization_demoxml
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

        // Parameterless constructor is required for serialization
        public Employee()
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\serRsult\Sample.xml";
            Employee emp = new Employee(21, "vysh");

            // Serialize object to XML
            XmlSerializer serializer = new XmlSerializer(typeof(Employee));
            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                serializer.Serialize(stream, emp);
            }

            Console.WriteLine("File created successfully");
            Console.ReadLine();
        }
    }
}
