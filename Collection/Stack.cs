using System;
using System.Collections;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
         Stack st=new Stack();
           
           st.Push('J');
           st.Push('e');
           st.Push('r');
           st.Push('r');
           st.Push('y');
           st.Push('I');
           st.Push('n');
           st.Push('d');
           st.Push('i');
           st.Push('a');
           
           Console.WriteLine("Stack Elements has :- ");
           foreach(object item in st)
           {
               Console.WriteLine(item);
           }
           
           Console.WriteLine("\nElement at top of stack :- {0}",st.Peek());
           
           Console.WriteLine("\nJ is present in stack :- {0}",st.Contains('J'));
           
           st.Pop();
           Console.WriteLine("\nStack Elements has after st.Pop():- ");
           foreach(object item in st)
           {
               Console.WriteLine(item);
           }
           
           st.Clear();
        }
    }
}
