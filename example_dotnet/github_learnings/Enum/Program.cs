using System;
namespace Enum{
    class Program{

             enum Level{
                first,
                second=6,
                third
            
             }
             static void Main(string[] args){
                Level var2 = Level.second;
                Console.WriteLine(var2);

                int num1 = (int)Level.third;
                Console.WriteLine(num1);
             }
    }
}
