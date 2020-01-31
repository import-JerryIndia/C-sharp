using System;

namespace testing
{
      
    class Program
    {
        private int ph_no;
        private string name;
        private Program()
        {
            ph_no=132456456;
            name="John Doe";
        }

        public void getData(out int no,out string name1)
        {
            no=ph_no;
            name1=name;
        }
        public static void Main(string[] args)
        {
           Program p1=new Program();
           int no;
           string name;

           p1.getData(out no,out name);

          Console.WriteLine("ph.no := "+no);
          Console.WriteLine("Name := "+name);

          Console.ReadKey();
            
        }
    }
}

/*
Output:- 
    PS C:\Users\Aniket\Desktop\csharp\testing> dotnet run
        ph.no := 132456456
        Name := John Doe
*/