using System;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;

namespace Serialization_dataContract
{
    [D]
    class Employee
    {
        public int id { get; set; }
        public string Name { get; set; }
        public Employee(int id,string Name)
        {
            this.id = id;
            this.Name = Name;
        }
        public Employee()
        {

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            string path = @"C:\serRsult\Example.xml";
            DataContractSerializer serializer = new DataContractSerializer(typeof(Employee));
            using (FileStream fs = new FileStream("Example.xml", FileMode.OpenOrCreate))
            {
                serializer.WriteObject(fs, emp);

                Console.WriteLine("xml file created successfully");
            }
            Console.ReadLine();
        }

    
    }
     
}