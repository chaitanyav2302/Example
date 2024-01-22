using System;
using System.Text;

namespace   Var{
class Program
{
static void Main(string[] args)
{
var a = 20;
var b = 13.45f;
var c = 'X';
var d = "Hello";
Console.WriteLine("value of a {0}, type {1}", a,a.GetType());
Console.WriteLine("value of b {0}, type {1}", b,b.GetType());
Console.WriteLine("value of c {0}, type {1}", c,c.GetType());
Console.WriteLine("value of d {0}, type {1}", d,d.GetType());


 dynamic d1 = 10;
 dynamic d2;
 d2=new Program();
 dynamic d3="string value";


}
}
}