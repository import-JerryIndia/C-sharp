using System;

namespace testing
{
      public class static_constructor
      {
          public static_constructor()
          {
            // that is regular constructor...  
            Console.WriteLine("REGULAR CONSTRUCTOR....");     
          }

          static static_constructor()
          {
              // that is static constructor... 
              Console.WriteLine("static constructor....");
          }     
      }
    class Program
    {
        public static void Main(string[] args)
        {
            static_constructor s1=new static_constructor();
            Console.ReadKey();
        }
    }
}

/*
Output:- 
    PS C:\Users\Aniket\Desktop\csharp\testing> dotnet run
        static constructor....
        REGULAR CONSTRUCTOR....
*/