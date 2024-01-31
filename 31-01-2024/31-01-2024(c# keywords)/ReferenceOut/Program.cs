using System;
namespace ReferenceOut
{
    class Program
    {
        static void Example(int a)
        {
            a = a + 1;                           //here if dont use ref keyword in the method signature 
                                                 //or if we dont pass the ref in the method the changes made to the varible or argument
                                                  //inside the method will not reflect here
                                               //the variable needs to be initialised before passing as a ref
            
        }

         static void ExampleRef( ref int x)
        {
            x = x + 1;
        }

        static void OutExample(out int x , out int y)
        {
            x = 10;
            y = 20;
        }


        static void Main(string[] args)
        {
            int a = 10;
            Program.Example(a);
            Console.WriteLine(a);   //here the value is not updated bcz we havent passed the reference

            int b = 10;
            Program.ExampleRef(ref b);
            Console.WriteLine(b);//here the value is changed

            int p, q;
            Program.OutExample(out p,out q);
            Console.WriteLine(p + " " + q);

        }

    }
    
}