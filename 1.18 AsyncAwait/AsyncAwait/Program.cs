using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;

namespace AsyncAwait
{
    public static class Program
    {
        //As you have seen, long-running CPU-bound tasks can be handed to another thread by using the Task object. But when doing work that’s 
        //input/output(I/O)–bound, things go a little differently.
        //When your application is executing an I/O operation on the primary application thread, Windows notices that your thread is waiting for the 
        //I/O operation to complete.Maybe you are accessing some file on disk or over the network, and this could take some time.
        //Because of this, Windows pauses your thread so that it doesn’t use any CPU resources.But while doing this, it still uses memory, and the thread 
        //can’t be used to serve other requests, which in turn will lead to new threads being created if requests come in.
        //Asynchronous code solves this problem.Instead of blocking your thread until the I/O operation finishes, you get back a Task object that represents
        //the result of the asynchronous operation.By setting a continuation on this Task, you can continue when the I/O is done.In the meantime, your
        //thread is available for other work. When the I/O operation finishes, Windows notifies the runtime and the continuation Task is scheduled on
        //the thread pool.
        //But writing asynchronous code is not easy. You have to make sure that all edge cases are handled and that nothing can go wrong.Because of this 
        //predicament, C# 5 has added two new keywords to simplify writing asynchronous code. Those keywords are async and await.
        //You use the async keyword to mark a method for asynchronous operations. This way, you signal to the compiler that something asynchronous is going
        //to happen.The compiler responds to this by transforming your code into a state machine.


        public static void Main()
        {
            string result = DownloadContent().Result;
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static async Task<string> DownloadContent()
        {
            using (HttpClient client = new HttpClient())
            {
                //A method marked with async just starts running synchronously on the current thread.What it does is enable the method to be split into 
                //multiple pieces. The boundaries of these pieces are marked with the await keyword.
                //When you use the await keyword, the compiler generates code that will see whether your asynchronous operation is already finished.If it is, 
                //your method just continues running synchronously. If it’s not yet completed, the state machine will hook up a continuation method that should 
                //run when the Task completes.Your method yields control to the calling thread, and this thread can be used to do other work.

                string result = await client.GetStringAsync("http://www.microsoft.com");
                
                return result;
            }
        }
    }
}
