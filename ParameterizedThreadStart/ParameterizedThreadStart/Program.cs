using System;
using System.Threading;

namespace ParameterizedThread
{
    class Program
    {
        //The Thread constructor has another overload that takes an instance of a ParameterizedThreadStart
        //delegate. This overload can be used if you want to pass some data through
        //the start method of your thread to your worker method
        public static void ThreadMethod(object o)
        {
            //In this case, the value 5 is passed to the ThreadMethod as an object.You can cast it to the
            //expected type to use it in your method.
            for (int i = 0; i < (int)o; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0);
            }
        }
        public static void Main()
        {
            Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));
            t.Start(5);
            t.Join();
        }
    }
}
