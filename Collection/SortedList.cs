using System;
using System.Collections;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
         SortedList s1=new SortedList();
           
           s1.Add("Jio",9689776706);
           s1.Add("Airtel",7028100949);
           s1.Add("Bsnl",9423830107);
           s1.Add("Idea",7038238514);
           
           Console.WriteLine("\nList elements by Sorted order of Keys:- ");
           foreach(object item in s1.Keys)
           {
               Console.WriteLine("{0}:{1}",item,s1[item]);
           }
           
           
           Console.WriteLine("\nKey at 2nd location:- {0}",s1.GetKey(2));
           
           Console.WriteLine("\nSortedList contains key Jio? :- {0}",s1.ContainsKey("Jio"));
           
           Console.WriteLine("\nSortedList contains Value 9689776706? :- {0}",s1.ContainsValue(9689776706));
           
           s1.Clear();
        }
    }
}
