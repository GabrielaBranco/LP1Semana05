using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch crono1 = new Stopwatch();
            crono1.Start();
            Thread.Sleep(600);
            crono1.Stop();

            Stopwatch crono2 = new Stopwatch();
            crono2.Start();
            Thread.Sleep(200);
            crono2.Stop();

            TimeSpan ts = crono1.Elapsed;
            TimeSpan ts2 = crono2.Elapsed;

            string elapsedTime = String.Format("{0:00}.{1}",ts.Seconds,
                ts.Milliseconds / 100);
            string elapsedTime2 = String.Format("{0:00}.{1}",ts2.Seconds,
                ts2.Milliseconds / 100);

            Console.WriteLine(elapsedTime + " segundos");
            Console.WriteLine(elapsedTime2 + " segundos");


        }
    }
}
