using System;
using System.Threading;
namespace ThreadAttributeStatic
{
    public static class Program
    {
        //A thread can also have its own data that’s not a local variable.By marking a field with
        //the ThreadStatic attribute, each thread gets its own copy of a field
        [ThreadStatic]
        public static int _field;
        public static void Main()
        {
            new Thread(() =>
            {
                for (int x = 0; x < 10; x++)
                {
                    _field++;
                    Console.WriteLine("Thread A: {0}", _field);
                }
                }).Start();

                new Thread(() =>
                {
                    for(int x = 0; x< 10; x++)
                    {
                        _field++;
                        Console.WriteLine("Thread B: {0}", _field);
                    }
                }).Start();
            Console.ReadKey();

            //With the ThreadStaticAttribute applied, the maximum value of _field becomes 10.
            //If you remove it, you can see that both threads access the same value and it becomes 20.
        }
    }
}