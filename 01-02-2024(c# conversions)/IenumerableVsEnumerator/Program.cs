using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> marks = new List<int>();
        marks.Add(87);
        marks.Add(88);
        marks.Add(89);
        marks.Add(90);
        marks.Add(91);
        marks.Add(93);
        marks.Add(94);
        marks.Add(95);

       /* IEnumerable<int> en = (IEnumerable<int>)marks;
        foreach(int i in en)
          {
              Console.WriteLine(i);
          }*/
        IEnumerator<int> en2 = marks.GetEnumerator();
        EnumeratorMarksBelow90(en2);
        /*while (en2.MoveNext)
        {
            Console.WriteLine(en2.Current.ToString);
        }*/
        static void EnumeratorMarksBelow90(IEnumerator<int> i)
        {
            while (i.MoveNext())
            {
                Console.WriteLine(value: i.Current.ToString());
                if (Convert.ToInt32(i.Current)>89)
                   {
                    EnumeratorMarksAbove90(i);
                   }
            }
        };
        static void EnumeratorMarksAbove90(IEnumerator<int> i)

        {  
            Console.WriteLine("people who got marks above 100")
            while (i.MoveNext())
            {
                Console.WriteLine(i.Current.ToString());
            }
        };



    }
}