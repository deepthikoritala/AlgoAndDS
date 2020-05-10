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
            solve(new List<int>() { 10,20});
            Console.ReadLine();
        }
        public static List<int> solve(List<int> A)
        {
            List<int> res = new List<int>();
            int max = A[0];
            foreach (int i in A) {
                if (i > max) {
                    max = i;
                }
            }

            int[] factorcount = new int[max+1];
            factorcount[0] = 0;
            factorcount[1] = 1;
            for (int i = 2; i < factorcount.Length; i++)
                factorcount[i] = 2;

            for (int i = 2; i <=max; i++) {
   
                    for (int j = i*2; j <= max; j+=i)
                    {
                        factorcount[j] = factorcount[j]+1;
                    }   
            }

            foreach (int i in A) {
                res.Add(factorcount[i]);
            }
            return res;
        }

    }
}
