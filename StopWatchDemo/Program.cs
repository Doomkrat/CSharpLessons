using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatchDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Press enter to start the timer.");
            Console.ReadLine();

            StopWatch watch = new StopWatch();
            watch.Start();

            Console.Write("Press enter to stop the time.");
            Console.ReadLine();
            watch.Stop();

            Console.ReadLine();
        }
    }
}
