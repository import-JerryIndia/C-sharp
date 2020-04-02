using System;
using System.Collections;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
           ArrayList a1=new ArrayList();

           a1.Add(1);
           a1.Add(2);
           a1.Add(1);
           a1.Add(3);
           a1.Add(4);
           a1.Add(5);
           a1.Add(6);
           a1.Add(7);

            Console.WriteLine("Elements at ArrayList:-");
           foreach (object item in a1)
           {
               Console.Write("-- {0}",item);
           }

            a1.Sort();
            Console.WriteLine("\nElements at ArrayList after Sort():-");
            foreach (object item in a1)
            {
                Console.Write("-- {0}",item);
            }

            a1.Remove(1);
            Console.WriteLine("\nElements at ArrayList After Remove():-");
            foreach (object item in a1)
            {
                Console.Write("-- {0}",item);
            }

            a1.RemoveAt(5);
            Console.WriteLine("\nElements at ArrayList After RemoveAt(5):-");
            foreach (object item in a1)
            {
                Console.Write("-- {0}",item);
            }

            a1.Reverse();
            Console.WriteLine("\nElements at ArrayList After Reverse():-");
            foreach (object item in a1)
            {
                Console.Write("-- {0}",item);
            }

            a1.Insert(5,6);
            Console.WriteLine("\nElements at ArrayList After InsertAt(5,6):-");
            foreach (object item in a1)
            {
                Console.Write("-- {0}",item);
            }

            
            Console.WriteLine("\nElements at ArrayList After Count:-{0}",a1.Count);
            
            a1.Clear();
            Console.WriteLine("\nElements at ArrayList After Clear():-");
            foreach (object item in a1)
            {
                Console.Write("-- {0}",item);
            }
        }
    }
}
