using System;
using System.Reflection;

namespace Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            Type T = typeof(Customer);
            Console.WriteLine("Full name = {0}", T.FullName);
            Console.WriteLine("Name = {0}", T.Name);
            Console.WriteLine("Namespace = {0}", T.Namespace);
            Console.WriteLine("properties in customers");

            PropertyInfo[] properties = T.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.Name);
                Console.WriteLine(property.PropertyType.Name);
            }

            Console.WriteLine();
            Console.WriteLine("methods in customers");
            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.Name);
                Console.WriteLine(method.ReturnType.Name+ " "+ method.Name);
            }
            Console.WriteLine();
            Console.WriteLine("constructors in customers");
            ConstructorInfo[] constructors = T.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.Name);
               Console.WriteLine(constructor.ToString());
            }





        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Customer(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public Customer()
        {
        }

        public void PrintId()
        {
            Console.WriteLine("ID = {0}", this.Id);
        }

        public void PrintName()
        {
            Console.WriteLine("Name = {0}", this.Name);
        }
    }
}
