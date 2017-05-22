using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace Parallelism
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parallelism involves taking a certain task and splitting it into a set of related tasks that can be executed concurrently. 
            //This also means that you shouldn’t go through your code to replace all your loops with parallel loops.You should use the 
            //Parallel class only when your code doesn’t have to be executed sequentially.

            //Increasing performance with parallel processing happens only when you have a lot of work to be done that can be executed 
            //in parallel. For smaller work sets or for work that has to synchronize access to resources, using the Parallel class can 
            //hurt performance. The best way to know whether it will work in your situation is to measure the results.

            Parallel.Invoke(() => ExecutarPrimeiraTarefa(), () => ExecutarSegundaTarefa(), () => ExecutarTerceiraTarefa(), () => ExecutarQuartaTarefa());

            Console.ReadKey();

            //Exemplo utilizando for e foreach
            //Parallel.For(0, 10, i =>
            //{
            //    Thread.Sleep(1000);
            //});
            //var numbers = Enumerable.Range(0, 10);
            //Parallel.ForEach(numbers, i =>
            //{
            //    Thread.Sleep(1000);
            //});

            //You can cancel the loop by using the ParallelLoopState object. You have two options to do this: Break or Stop. 
            //Break ensures that all iterations that are currently running will be finished. Stop just terminates everything.
            //1.17:
            //ParallelLoopResult result = Parallel.
            //For(0, 1000, (int i, ParallelLoopState loopState) =>
            //{
            //    if (i == 500)
            //    {
            //        Console.WriteLine("Breaking loop");
            //        loopState.Break();
            //    }
            //    return;
            //});
        }

        public static void ExecutarPrimeiraTarefa()
        {
            Console.WriteLine("Executando Primeira Tarefa ");
            Thread.Sleep(4000);
            Console.WriteLine("Primeira Tarefa Completa");
        }

        public static void ExecutarSegundaTarefa()
        {
            Console.WriteLine("Executando Segunda Tarefa ");
            Thread.Sleep(2000);
            Console.WriteLine("Segunda Tarefa Completa");
        }

        public static void ExecutarTerceiraTarefa()
        {
            Console.WriteLine("Executando Terceira Tarefa ");
            Thread.Sleep(1000);
            Console.WriteLine("Terceira Tarefa Completa");
        }

        public static void ExecutarQuartaTarefa()
        {
            Console.WriteLine("Executando Quarta Tarefa ");
            Thread.Sleep(5000);
            Console.WriteLine("Quarta Tarefa Completa");
        }        
    }
}
