using System;
using System.Threading;

namespace BackgroundThread
{
    public static class Program
    {
        //Another thing that’s important to know about threads is the difference between foreground
        //and background threads.Foreground threads can be used to keep an application
        //alive.Only when all foreground threads end does the common language runtime (CLR) shut
        //down your application.Background threads are then terminated.
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(1000);
            }
        }
        public static void Main()
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));

            //If you run this application with the IsBackground property set to true, the application exits
            //immediately.If you set it to false(creating a foreground thread), the application prints the
            //ThreadProc message ten times.
            t.IsBackground = true;
            t.Start();
            //Console.ReadLine();
        }
    }
}
