using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

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
