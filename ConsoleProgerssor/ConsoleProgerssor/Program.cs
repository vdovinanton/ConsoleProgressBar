using System;
using System.Threading;

namespace ConsoleProgerssor
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Performing some task... ");

            const int totalProgressCount = 100;

            using (var progress = new ProgressBar())
            {
                for (var i = 0; i <= totalProgressCount; i++)
                {
                    progress.Report((double)i / totalProgressCount);
                    Thread.Sleep(50);
                }
            }
            Console.WriteLine("Done.");
            Console.ReadKey();
        }
    }
}
