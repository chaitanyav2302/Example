using System;
using System.Data;
using System.Xml.XPath;

public delegate int   MyDel(int x,int y);

class Program
{  
     public static int  add(int x,int y){
                  return (x+y);
                //   My comment

                // my another comment
        }
        public static int multiply(int x,int y){
                  return (x*y);
        }
    static void Main()
    {
       MyDel del = new MyDel(add);
       del+=multiply;
       int res = del(20,10);          
                      //here we only get the reuslt of the multiplication bcz the 
                     //methods are returning something and the value is getting overrided 
                     //if you wwant to print both the outputs write "void" with method signatures 
                     //and remove "return" and write the print statements
        
    Console.WriteLine(res);
     
        
}
}
