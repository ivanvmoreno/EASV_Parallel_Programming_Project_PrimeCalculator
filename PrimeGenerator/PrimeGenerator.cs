using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PrimeGenerator
{
    public static class PrimeGenerator
    {
        public static bool IsPrime(long number)
        {
            if (number == 1 || number == 0)
                return false;
            else if (number != 2 && number % 2 == 0)
                return false;
            else
                for (int i = 2; i <= number / 2; i++)
                {
                    if (number % i == 0) return false;
                }
                return true;
        }

        public static List<long> GetPrimesSequential(long first, long last)
        {
            List<long> primeNumbers = new List<long>();
            for (long i = first; i < last; i++)
            {
                if (IsPrime(i)) primeNumbers.Add(i);
            }
            return primeNumbers;
        }
       
        public static List<long> GetPrimesParallel(long first, long last)
        {
            List<long> primeNumbers = new List<long>();
            Parallel.ForEach(
                Partitioner.Create(first, last),
                () => new List<long>(),
                (Tuple<long, long> range, ParallelLoopState state, List<long> localPrimes) =>
                {
                    for (int i = (int)range.Item1; i < range.Item2; i++)
                    {
                        if (IsPrime(i)) localPrimes.Add(i);
                    }
                    return localPrimes;
                },
                (localPrimes) =>
                {
                    lock (primeNumbers)
                    {
                        primeNumbers.AddRange(localPrimes);
                    }
                });
            primeNumbers.Sort();
            return primeNumbers;
        }
    }
}
