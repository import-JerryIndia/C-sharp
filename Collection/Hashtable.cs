using System;
using System.Collections;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
         Hashtable ht = new Hashtable();

           ht.Add("Aniket",1854005);
           ht.Add("Amrut",1854008);
           ht.Add("Nilesh",1854011);
           ht.Add("Swapnil",1854015);
           ht.Add("Balram",1854016);

           Console.WriteLine("Hashtable Contains:-"); 
           foreach (object item in ht.Keys)
           {
               Console.WriteLine("{0}:{1}",item,ht[item]);
           }
           
           ht.Remove("Aniket");
           Console.WriteLine("\n\nHashtable Contains after ht.Remove():-"); 
           foreach (object item in ht.Keys)
           {
               Console.WriteLine("{0}:{1}",item,ht[item]);
           }
           
           Console.WriteLine("\n\n Is Hashtable Contains Aniket ? :-{0}",ht.ContainsKey("Aniket")); 
           
           Console.WriteLine("\n\n Is Hashtable Contains 1854008 ? :-{0}",ht.ContainsValue(1854008));
           
           ht.Clear();
        }
    }
}
