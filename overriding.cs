using System;

namespace testing
{
      public class Base
      {
          public void display()
          {
            Console.WriteLine("display from Base class...");
          }
      }
      public class Derived:Base
      {
          public new void display()
          {
              //that is another method to call base class methods...
              //Base b1=new Base();
              //b1.display();
              Console.WriteLine("display from derived class...");
          }
      }
    class Program
    {
        public static void Main(string[] args)
        {
            Derived s1=new Derived();
            s1.display();
            Console.ReadKey();
        }
    }
}

/*
Output:- 
    PS C:\Users\Aniket\Desktop\csharp\testing> dotnet run
        display from derived class...
*/