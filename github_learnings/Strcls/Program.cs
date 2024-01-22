using System;
namespace Strcls{
   public class Example{
        public string name;
         public string branch;
         public int rollnum;

        public void details(string name,int rollnum,string branch){
            this.name = name;
            this.rollnum = rollnum;
            this.branch=branch;
             
             Console.WriteLine(name);
              Console.WriteLine(branch);
              Console.WriteLine(rollnum);
        }
   }
   public struct Example2{
    public string Brand;
    public string Model;
    public int  Cost;
   }
    class Program{
        static void Main(string[] args)
              {
                Example e = new Example();
                e.details("vysh",21,"cse");

                Example2 e2;
                e2.Brand="audi";
                e2.Model="g7";
                e2.Cost=10000;

                Console.WriteLine(" brand :"+e2.Brand+" Cost :"+e2.Cost+" Model :"+e2.Model);
                      
              }
    }
}