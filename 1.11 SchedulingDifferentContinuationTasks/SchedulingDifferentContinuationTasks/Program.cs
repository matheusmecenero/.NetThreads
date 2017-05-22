using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingDifferentContinuationTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //The ContinueWith method has a couple of overloads that you can use to configure when the 
            //continuation will run.This way you can add different continuation methods that will run 
            //when an exception happens, the Task is canceled, or the Task completes successfully.

            Task<int> t = Task.Run(() =>
            {
                return 42;
            });

            //To return "Faulted" and comment task above:
            //Task t = Task.Run(() =>
            //{
            //    throw new Exception(); ;
            //});

            t.ContinueWith((i) =>
            {
                Console.WriteLine("Canceled");
            }, TaskContinuationOptions.OnlyOnCanceled);

            t.ContinueWith((i) =>
            {
                Console.WriteLine("Faulted");
            }, TaskContinuationOptions.OnlyOnFaulted);

            var completedTask = t.ContinueWith((i) =>
            {
                Console.WriteLine("Completed");
            }, TaskContinuationOptions.OnlyOnRanToCompletion);

            completedTask.Wait();

            Console.ReadKey();
        }
    }
}
