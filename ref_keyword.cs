using System;

namespace testing
{
      public class ref_keyword
      {
          private String c_name;
          public ref_keyword()
          {
            // that is constructor...
            c_name="Hey we are new Developers...";
            
          }

          public string str(ref string name)
          {
              c_name=name;
              return c_name;
          }

        
      }
    class Program
    {
        public static void Main(string[] args)
        {
            ref_keyword p1=new ref_keyword();
            string name="we are indians";
            
            Console.WriteLine("String is :- "+p1.str(ref name));

            Console.ReadKey();
        }
    }
}

/*
Output:- 
    PS C:\Users\Aniket\Desktop\csharp\testing> dotnet run
        String is :- we are indians
*/