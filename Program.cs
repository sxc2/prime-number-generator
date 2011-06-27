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
