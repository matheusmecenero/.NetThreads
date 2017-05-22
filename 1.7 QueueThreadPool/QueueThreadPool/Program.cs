using System;
using System.Threading;

namespace QueueThreadPool
{
    class Program
    {
        public static void Main()
        {
            //A thread pool is created to reuse those threads, similar to the way a database connection 
            //pooling works. Instead of letting a thread die, you send it back to the pool where it can 
            //be reused whenever a request comes in.
            ThreadPool.QueueUserWorkItem((s) =>
            {
                Console.WriteLine("Working on a thread from threadpool");
            });
            Console.ReadLine();

            //Take, for example, a web server that serves incoming requests.All those requests come in
            //at an unknown time and frequency.The thread pool ensures that each request gets added to
            //the queue and that when a thread becomes available, it is processed.This ensures that your
            //server doesn’t crash under the amount of requests.If you span threads manually, you can
            //easily bring down your server if you get a lot of requests.Each request has unique characteristics
            //in the work they need to do.What the thread pool does is map this work onto the
            //threads available in the system. Of course, you can still get so many requests that you run
            //out of threads. Requests then start to queue up and this leads to your web server becoming
            //unresponsive.


        }
    }
}
