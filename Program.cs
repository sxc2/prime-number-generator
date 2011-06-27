using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace primenumbergenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool slow = false;
            char fastOrSlow = 'F';

            Console.Write("(S)low or (F)ast?");
            string speed = Console.ReadLine();
            if (Char.TryParse(speed, out fastOrSlow))
            {
                if (fastOrSlow.Equals('S'))
                {
                    slow = true;
                }
            }

            if (slow)
                slowPrimeNumbers();
            else
                fastPrimeNumbers();
        }

        /// <summary>
        /// improved version, probably O(n*log(n))
        /// </summary>
        private static void fastPrimeNumbers()
        {
            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(2);

            int index = 3;
            while (true)
            {
                bool isPrime = true;

                for (int i = 0; i < primeNumbers.Count; i++)
                {
                    if ((index % primeNumbers[i]) == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.Write(index + " ");
                    primeNumbers.Add(index);
                    Thread.Sleep(500);
                }

                index++;
            }
        }

        /// <summary>
        /// basic prime number generator O(n^2)
        /// </summary>
        private static void slowPrimeNumbers()
        {
            int index = 1;
            while (true)
            {
                bool isPrime = true;

                for (int i = 2; i < index; i++)
                {
                    if ((index % i) == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.Write(index + " ");
                    Thread.Sleep(500);
                }

                index++;
            }
        }
    }
}
