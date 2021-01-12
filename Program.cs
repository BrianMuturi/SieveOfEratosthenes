using System;
using System.Collections;
using System.Collections.Generic;

namespace SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                bool invalid = true;
                while (invalid)
                {
                    Console.Write("Enter your last number in the prime sequence(1-100):");
                    int n = Convert.ToInt32(Console.ReadLine());
                    if (n >= 0 && n <= 100)
                    {
                        bool[] prime = new bool[n + 1];
                        for (int i = 2; i <= n; i++) prime[i] = true;
                        {
                            int limit = (int)Math.Ceiling(Math.Sqrt(n));

                            for (int i = 2; i <= limit; i++)
                            {
                                if (prime[i])
                                {
                                    for (int j = i * i; j <= n; j += i)
                                    {
                                        prime[j] = false;
                                    }
                                }
                            }
                        }
                        Console.WriteLine($"Prime Numbers upto {n}");

                        for (int i = 0; i <= n; i++)
                        {
                            if (prime[i])
                            {
                                Console.WriteLine(i);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry!!");
                    }
                }

            }
        }

        
    }
}