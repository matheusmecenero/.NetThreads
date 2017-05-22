using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAddingAContinuation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Because of the object-oriented nature of the Task object, one thing you can do is add a continuation 
            //task. This means that you want another operation to execute as soon as the Task finishes.
            Task<int> t = Task.Run(() =>
            {
                return 42;
            }).ContinueWith((i) =>
            {
                return i.Result * 2;
            });
            Console.WriteLine(t.Result); // Displays 84
            Console.ReadKey();
        }
    }
}
