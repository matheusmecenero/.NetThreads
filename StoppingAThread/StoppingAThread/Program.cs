using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StoppingAThread
{
    class Program
    {
        //To stop a thread, you can use the Thread.Abort method.However, because this method
        //is executed by another thread, it can happen at any time. When it happens, a ThreadAbort-
        //Exception is thrown on the target thread.This can potentially leave a corrupt state and make
        //your application unusable.

        public static void Main()
        {
            //A better way to stop a thread is by using a shared variable that both your target and your
            //calling thread can access.
            bool stopped = false;

            //In this case, the thread is initialized with a lambda expression (which in turn is just a shorthand version of a delegate).
            Thread t = new Thread(new ThreadStart(() =>
            {
                //The thread keeps running until stopped becomes true.
                while (!stopped)
                {
                    Console.WriteLine("Running...");
                    Thread.Sleep(1000);
                }
            }));
            t.Start();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            stopped = true;
            t.Join();
        }
    }
}
