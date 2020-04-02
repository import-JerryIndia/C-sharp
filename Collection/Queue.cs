using System;
using System.Collections;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
         Queue Q=new Queue();
           
           Q.Enqueue(11);
           Q.Enqueue(12);
           Q.Enqueue(13);
           Q.Enqueue(14);
           Q.Enqueue(15);
           Q.Enqueue(16);
           Q.Enqueue(17);
           Q.Enqueue(18);
           Q.Enqueue(19);
           Q.Enqueue(20);
           
           Console.WriteLine("Queue Elements has :- ");
           foreach(object item in Q)
           {
               Console.WriteLine(item);
           }
           
           
           Console.WriteLine("\n11 is present in Queue :- {0}",Q.Contains(11));
           
           Q.Dequeue();
           Console.WriteLine("\nQueue Elements has after Q.Dequeue():- ");
           foreach(object item in Q)
           {
               Console.WriteLine(item);
           }
           
           Q.Clear();
        }
    }
}
