using System;
using System.Diagnostics;

namespace PrimeGenerator
{
    class PrimeGeneratorTests
    {
        static void Main(string[] args)
        {
            Stopwatch sw = Stopwatch.StartNew();
            PrimeGenerator.GetPrimesSequential(0, 1_000_000);
            sw.Stop();
            Console.WriteLine("Sequential approach (0 - 1m) – {0:f3} sec.", sw.ElapsedMilliseconds / 1000d);

            sw = Stopwatch.StartNew();
            PrimeGenerator.GetPrimesParallel(0, 1_000_000);
            sw.Stop();
            Console.WriteLine("Parallel approach (0 - 1m) – {0:f3} sec.", sw.ElapsedMilliseconds / 1000d);

            sw = Stopwatch.StartNew();
            PrimeGenerator.GetPrimesSequential(0, 10_000_000);
            sw.Stop();
            Console.WriteLine("Sequential approach (0 - 10m) – {0:f3} sec.", sw.ElapsedMilliseconds / 1000d);

            sw = Stopwatch.StartNew();
            PrimeGenerator.GetPrimesParallel(0, 10_000_000);
            sw.Stop();
            Console.WriteLine("Parallel approach (0 - 10m) – {0:f3} sec.", sw.ElapsedMilliseconds / 1000d);

            sw = Stopwatch.StartNew();
            PrimeGenerator.GetPrimesSequential(1_000_000, 2_000_000);
            sw.Stop();
            Console.WriteLine("Sequential approach (1m - 2m) – {0:f3} sec.", sw.ElapsedMilliseconds / 1000d);

            sw = Stopwatch.StartNew();
            PrimeGenerator.GetPrimesParallel(1_000_000, 2_000_000);
            sw.Stop();
            Console.WriteLine("Parallel approach (1m - 2m) – {0:f3} sec.", sw.ElapsedMilliseconds / 1000d);

            sw = Stopwatch.StartNew();
            PrimeGenerator.GetPrimesSequential(10_000_000, 20_000_000);
            sw.Stop();
            Console.WriteLine("Sequential approach (10m - 20m) – {0:f3} sec.", sw.ElapsedMilliseconds / 1000d);

            sw = Stopwatch.StartNew();
            PrimeGenerator.GetPrimesParallel(10_000_000, 20_000_000);
            sw.Stop();
            Console.WriteLine("Parallel approach (10m - 20m) – {0:f3} sec.", sw.ElapsedMilliseconds / 1000d);
        }
    }
}
