using System.Threading;
using System.Threading.Tasks;

namespace ScalabilityVersusResponsiveness
{
    class Program
    {
        static void Main(string[] args)
        {
            //Making a scalable application that uses fewer threads is another story.Making code scale better is about changing the actual implementation of the code.

           //SleepAsyncA:
           Task.Run(() => Thread.Sleep(1000));

            //SleepAsyncB:
            TaskCompletionSource<bool> tcs = null;
            var t = new Timer(delegate { tcs.TrySetResult(true); }, null, -1, -1);
            tcs = new TaskCompletionSource<bool>(t);
            t.Change(1000, -1);

            //The SleepAsyncA method uses a thread from the thread pool while sleeping.The second method, however, which has a completely different 
            //implementation, does not occupy a thread while waiting for the timer to run.The second method gives you scalability.
            //When using the async and await keywords, you should keep this in mind.Just wrapping each and every operation in a task and awaiting them won’t 
            //make your application perform any better.It could, however, improve responsiveness, which is very important in client applications.
        }
    }
}
