// See https://aka.ms/new-console-template for more information
using System;
using Void;
namespace Void{
    class Example{
           public void hello(){
            Console.WriteLine("hello world");
           } 
           public void addition(int a,int b){
            int sum = a + b;
             Console.WriteLine(sum);

           } 
    };
    class Program{
                 static void Main(string[] args){
                       Example e = new Example();
                       e.hello();
                       e.addition(1,2);
                 }
    }
}
