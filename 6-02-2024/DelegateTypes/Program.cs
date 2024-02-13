using System;

namespace DelegateTypes
{
    public delegate double Delegate1(int x, float y, double z);
    public delegate void Delegate2(int x, float y, double z);
    public delegate bool Delegate3(string str);

    public class Program
    {
        public static double AddNums1(int x, float y, double z)
        {
            return x + y + z;
        }

        public static void AddNums2(int x, float y, double z)
        {
            Console.WriteLine(x + y + z);
        }

        public static bool CheckLength(string str)
        {
            if (str.Length > 5)
                return true;
            return false;
        }

        static void Main(string[] args)
        {
            Delegate1 obj1 = new Delegate1(AddNums1);
            Console.WriteLine(obj1(1, 2.35f, 12.234));


            Delegate2 obj2 = new Delegate2(AddNums2);
            


            Delegate3 obj3 = new Delegate3(CheckLength);
            Console.WriteLine(obj3("hello"));

        }
    }
}
