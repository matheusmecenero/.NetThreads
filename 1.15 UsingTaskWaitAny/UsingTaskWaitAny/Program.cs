using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace UsingTaskWaitAny
{
    public static class Program
    {
        public static void Main()
        {
            //Instead of waiting until all tasks are finished, you can also wait until one of the 
            //tasks is finished.You use the WaitAny method for this.

           Task <int>[] tasks = new Task<int>[3];

            tasks[0] = Task.Run(() => { Thread.Sleep(2000); return 1; });
            tasks[1] = Task.Run(() => { Thread.Sleep(1000); return 2; });
            tasks[2] = Task.Run(() => { Thread.Sleep(3000); return 3; });

            while (tasks.Length > 0)
            {
                //Executará o array de threads e retornará a que executar primeiro
                //Assim o exemplo mosta um caso que não espera todas executarem
                int i = Task.WaitAny(tasks);
                Task<int> completedTask = tasks[i];
                Console.WriteLine(completedTask.Result);
                var temp = tasks.ToList();
                temp.RemoveAt(i);
                tasks = temp.ToArray();
            }
        }
    }
}
