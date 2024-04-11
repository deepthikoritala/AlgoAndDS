using System;
using System.Collections.Generic;
using System.Linq;


//A = 9
//[2, 7]


//A = 20
//[3, 17]

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            primesum(9);
            Console.ReadLine();
        }
        public static List<int> primesum(int A)
        {
            List<int> res = new List<int>();
            bool[] isprime = new bool[A];
            for (int i = 0; i < isprime.Length; i++)
                isprime[i] = true;

            for (int i = 2; i * i < A; i++) {

                if (isprime[i] == true) {
                    //here making all multiples of numbers to not prime like if 2 is prime -> 4,6,8 are not prime
                    //3 is prime -> 9, 12,15 are not prime
                    for (int j = i*i; j < A; j+=i)
                    {
                        isprime[j] = false;
                    }

                }
            }

            for (int i = 2; i < A; i++) {

                if (isprime[i] && isprime[A - i]) {
                    res.Add(i);
                    res.Add(A-i);
                    break;
                }
            }

            return res;
        }

    }
}
