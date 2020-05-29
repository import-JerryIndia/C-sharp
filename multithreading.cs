using System;  
using System.Threading;  
public class MyThread  
{  
    public static void Thread1()  
    {  
        Thread t = Thread.CurrentThread;
        for (int i = 0; i < 10; i++)  
        {  
            Console.WriteLine(i);  
            Console.WriteLine(t.Name);
        }  
    }  
}  
public class ThreadExample  
{  
    public static void Main()  
    {  
        Thread t1 = new Thread(new ThreadStart(MyThread.Thread1));  
        Thread t2 = new Thread(new ThreadStart(MyThread.Thread1)); 
        
        t1.Name  = "Thread One";
        t2.Name = "Thread Two";
        
        t1.Start();  
        t2.Start();  
    }  
}  