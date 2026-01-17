using System.Diagnostics;

class Program
{
    static int counter=0;
    static object lockobj=new object();
    static void Main()
    {
        // Process currentProcess=Process.GetCurrentProcess();
        // Console.WriteLine("Current Process Id: "+currentProcess.Id);
        // Console.WriteLine("Process Name: "+currentProcess.ProcessName+currentProcess.StartTime+currentProcess.Threads+
        // currentProcess.WorkingSet64);
        //  Thread worker = new Thread(DoWork);

        // // Start the thread
        // worker.Start();

        // Console.WriteLine("Main thread continues...");

        // // Optional: Wait for worker thread to finish
        // worker.Join();
        // Console.WriteLine("Main thread finished");

        ///-------------->start a process at os level<----------------------
        // Process.Start("msedge.exe");
        // Thread t1=new Thread(increment);
        // Thread t2=new Thread(increment);
        // t1.Start();
        // t2.Start();
        // t1.Join();
        // Console.WriteLine("Final counter value : "+counter);

        //--------------------------------------------->try catch block<-------------------------------------
        // try
        // {
        //     Task t=Task.Run(()=>throw new Exception("Task error"));
        //     t.Wait();
        // }
        // catch(AggregateException ex)
        // {
        //     Console.WriteLine(ex.InnerExceptions[0].Message);
        // }
        // Task t1=Task.Run(()=>Console.WriteLine("task1"));
        // Task t2=Task.Run(()=>Console.WriteLine("task2"));

        // Task.WhenAll(t1,t2).ContinueWith(t=>Console.WriteLine("All taks are completed"));
        // Console.ReadLine();
        //---------------------->task Results<-------------------------------------------------

        Task<int> t1=Task.Run(()=>42);

        t1.ContinueWith(res=>Console.WriteLine("Result is : "+res.Result));
        Console.WriteLine();

    }
    static void increment()
    {
        for(int i=0;i<1000;i++)
        lock(lockobj)counter++;
    }
    static void DoWork()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Worker thread: " + i);
            Thread.Sleep(500); // Simulate work
        }
    }
}