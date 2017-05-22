using System;
using System.Threading;
using System.Threading.Tasks;

namespace UsingTaskWaitAll
{
    class Program
    {
        static void Main(string[] args)
        {
            //Next to calling Wait on a single Task, you can also use the method WaitAll to wait for 
            //multiple Tasks to finish before continuing execution.

            Task[] tasks = new Task[3];
            tasks[0] = Task.Run(() => {
                Thread.Sleep(1000);
                Console.WriteLine("1");
                return 1;
            });

            tasks[1] = Task.Run(() => {
                Thread.Sleep(1000);
                Console.WriteLine("2");
                return 2;
            });

            tasks[2] = Task.Run(() => {
                Thread.Sleep(1000);
                Console.WriteLine("3");
                return 3;
            });

            Task.WaitAll(tasks);

            //In this case, all three Tasks are executed simultaneously, and the whole run takes approximately 
            //1000ms instead of 3000.Next to WaitAll, you also have a WhenAll method that you can use to 
            //schedule a continuation method after all Tasks have finished.

            Console.ReadKey();
        }
    }
}
