using System;

namespace testing
{
      public class params_array
      {
          int sum,i;
          public params_array()
          {
            // that is constructor...
            sum=0;
            i=0;
          }

        public int sums(params int[] arr)
        {
            
            while(i!=arr.Length)
            {
                sum+=arr[i];
                i++;
            }
            return sum;
        }
      }
    class Program
    {
        public static void Main(string[] args)
        {
            params_array p1=new params_array();
            Console.WriteLine("Sum is :- "+p1.sums(1,2,3,4,5));

            Console.ReadKey();
        }
    }
}

/*
Output:- 
    PS C:\Users\Aniket\Desktop\csharp\testing> dotnet run
        Sum is :- 15
*/