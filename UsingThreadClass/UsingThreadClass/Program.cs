using System;
using System.Threading;
namespace UsingThreadClass
{
    public static class Program
    {
        //Example of using the Thread class to run a method on another thread.
        //The Console class synchronizes the use of the output stream for you so you can write to it
        //from multiple threads.Synchronization is the mechanism of ensuring that two threads don’t
        //execute a specific portion of your program at the same time. In the case of a console application,
        //this means that no two threads can write data to the screen at the exact same time.
        //If one thread is working with the output stream, other threads will have to wait before it’s
        //finished.
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc:{0}", i);
                Thread.Sleep(0);
            }
        }
        public static void Main()
        {

            //As you can see, both threads run and print their message to the console.The Thread.Join
            //method is called on the main thread to let it wait until the other thread finishes.
            //Why the Thread.Sleep(0) ? It is used to signal to Windows that this thread is finished.Instead
            //of waiting for the whole time - slice of the thread to finish, it will immediately switch to
            //another thread.
            //Both your process and your thread have a priority.Assigning a low priority is useful for
            //applications such as a screen saver.Such an application shouldn’t compete with other applications
            //for CPU time. A higher - priority thread should be used only when it’s absolutely necessary.
            //A new thread is assigned a priority of Normal, which is okay for almost all scenarios.
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Mainthread: Do some work. {0}", i);
                Thread.Sleep(0);
            }
            t.Join();
            Console.ReadLine();
        }
    }
}
// Displays
//Main thread: Do some work.
//ThreadProc: 0
//Main thread: Do some work.
//ThreadProc: 1
//Main thread: Do some work.
//ThreadProc: 2
//Main thread: Do some work.
//ThreadProc: 3
//ThreadProc: 4
//ThreadProc: 5
//ThreadProc: 6
//ThreadProc: 7
//ThreadProc: 8
//ThreadProc: 9
//ThreadProc: 10