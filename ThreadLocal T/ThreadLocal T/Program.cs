using System;
using System.Threading;
namespace ThreadLocalT
{
    public static class Program
    {
        //If you want to use local data in a thread and initialize it for each thread, 
        //you can use the ThreadLocal<T> class. This class takes a delegate to a method that initializes the value.Listing 1-6 shows an example.
        public static ThreadLocal<int> _field =
            new ThreadLocal<int>(() =>
            {
                return Thread.CurrentThread.ManagedThreadId;
            });

        public static void Main()
        {
            new Thread(() =>
            {
                for (int x = 0; x < _field.Value; x++)
                {
                    Console.WriteLine("Thread A: {0}", x);
                }
            }).Start();
            new Thread(() =>
            {
                for (int x = 0; x<_field.Value; x++)
                {
                    Console.WriteLine("Thread B: {0}", x);
                }
            }).Start();
            Console.ReadKey();
        }
    }
}
// Displays
// Thread B: 0
// Thread B: 1
// Thread B: 2
// Thread B: 3
// Thread A: 0
// Thread A: 1
// Thread A: 2