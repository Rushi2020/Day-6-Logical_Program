//      Stop Watch 

using System.Diagnostics;

namespace Stop_watch
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.ReadLine();
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.ReadLine();
            stopwatch.Stop();
            var elapsed_time = stopwatch.ElapsedMilliseconds;
            Console.WriteLine(elapsed_time / 1000);


        }
    }
}







