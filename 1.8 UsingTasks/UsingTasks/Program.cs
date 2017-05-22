using System;
using System.Threading.Tasks;
namespace UsingTasks
{
    public static class Program
    {
        public static void Main()
        {
            //Queuing a work item to a thread pool can be useful, but it has its shortcomings.There is no
            //built -in way to know when the operation has finished and what the return value is.

            //This is why the.NET Framework introduces the concept of a Task, which is an object that 
            //represents some work that should be done.The Task can tell you if the work is completed 
            //and if the operation returns a result, the Task gives you the result.

            Task t = Task.Run(() =>
            {
                for (int x = 0; x < 100; x++)
                {
                    Console.Write('*');
                }
            });

            //Wait is a synchronization method that causes the calling thread to wait until the current task has completed.
            t.Wait();

            Console.ReadKey();
            //This example creates a new Task and immediately starts it. Calling Wait is equivalent to 
            //calling Join on a thread. It waits till the Task is finished before exiting the application.
        }
    }
}
