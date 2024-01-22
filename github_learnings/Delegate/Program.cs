using System;

public delegate void  MyDel(int x,int y);

class Program
{  
     public static void add(int x,int y){
                  Console.WriteLine(x+y);
        }
        public static void multiply(int x,int y){
                  Console.WriteLine(x*y);
        }
    static void Main()
    {
       MyDel del = add;
       del+=multiply;           
                      //here we only get the reuslt of the multiplication bcz the 
                     //methods are returning something and the value is getting overrided 
                     //if you wwant to print both the outputs write "void" with method signatures 
                     //and remove "return" and write the print statements
        del(10,30);
    
     
        
}
}