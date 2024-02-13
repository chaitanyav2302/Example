using System;
namespace BoxingandUn{
    class Program{

        static void Main(string[] args){
        int a = 10;
         object o = a;  
                                         // Boxing is necessary when you want to treat a value type as an object, 
        //                                                  such as when you need to store it in a collection 
        //                                                  that only accepts reference types (e.g., ArrayList, List<object>).
         a =20;
         System.Console.WriteLine
        ("Value - type value of num is : {0}", a);
        System.Console.WriteLine
        ("Object - type value of obj is : {0}", o);
        }
    }
}
//Unboxing is necessary when you retrieve a value from a collection of objects
// (where it was stored as a boxed value) and want to use it as its original value type.