using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomLinkedList;

namespace CustomCollections
{

    class Program
    {
        static void Main(string[] args)
        {
            Vdlist<int> custList = new Vdlist<int>();
            custList.AddFirst(1);
            custList.AddFirst(2);
             custList.AddFirst(3);
             custList.AddFirst(4);
             custList.AddFirst(5);
             custList.AddLast(6);

            Console.WriteLine(custList.Contains(3));

            custList.AddBeforeElement(2, 10);
            Console.WriteLine(custList.Contains(6));
            Console.WriteLine(custList.Total());
            Console.WriteLine(custList.Count());
            custList.AddRange(custList.ToArray());

            foreach (int i in custList)
            {
                Console.WriteLine(i);
            }
        }
    }
}

