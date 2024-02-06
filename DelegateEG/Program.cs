using System;
using System.Data;
using System.Xml.XPath;

public delegate void  MyDel(int x,int y);

class Program
{  
        public static void  add(int x,int y){
                  Console.WriteLine(x+y);
                //   My comment
                // my another comment 
        }
        public static void  multiply(int x,int y){
                  Console.WriteLine(x*y);
        }
    static void Main()
    {
       MyDel del = new MyDel(add);
       del+=multiply;
       del(20,10);          
                      //here we only get the result of the multiplication bcz the 
                     //methods are returning something and the value is getting overrided 
                     //if you wwant to print both the outputs write "void" with method signatures 
                     //and remove "return" and write the print statements
        
    
     
        
}
}
