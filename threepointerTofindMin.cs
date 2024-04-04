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
            minimize(new List<int>(){ 1, 4, 10}, new List<int>() { 2, 15, 20 }, new List<int>() { 10, 12 });
            Console.ReadLine();
        }

        public static int minimize(List<int> A, List<int> B, List<int> C)
        {
            int res = -1, Apointer=0,BPointer=0,CPointer=0;
            bool breakLoop = false;
            while (!breakLoop)
            {
                int FirstAbs = 0, secAbs = 0, ThirAbs = 0;
                FirstAbs = getabs(A[Apointer], B[BPointer]);
                secAbs = getabs(B[BPointer], C[CPointer]);
                ThirAbs = getabs(C[CPointer], A[Apointer]);
              

                switch (getMaxPair(FirstAbs, secAbs, ThirAbs)) {

                    case 1:if (res < 0 || res > FirstAbs) {
                            res = FirstAbs;
                        }

                        if (A[Apointer] > B[BPointer])
                        {
                            if (BPointer < B.Count() - 1)
                            {
                                BPointer = BPointer + 1;
                            }
                            else
                            {
                                breakLoop = true;
                            }
                        }
                        else
                        {
                            if (Apointer < A.Count() - 1)
                            {
                                Apointer = Apointer + 1;
                            }
                            else
                            {
                                breakLoop = true;
                            }
                        }

                        break;
                    case 2:
                        if (res < 0 || res > secAbs)
                        {
                            res = secAbs;
                        }

                        if (B[BPointer] < C[CPointer])
                        {
                            if (BPointer < B.Count() - 1)
                            {
                                BPointer = BPointer + 1;
                            }
                            else
                            {
                                breakLoop = true;
                            }
                        }
                        else {

                            if (CPointer < C.Count() - 1)
                            {
                                CPointer = CPointer + 1;
                            }
                            else
                            {
                                breakLoop = true;
                            }
                        }

                        break;
                    case 3:
                        if (res < 0 || res > ThirAbs)
                        {
                            res = ThirAbs;
                        }
                        if (A[Apointer] > C[CPointer])
                        {
                            if (CPointer < C.Count() - 1)
                            {
                                CPointer = CPointer + 1;
                            }
                            else
                            {
                                breakLoop = true;
                            }
                        }
                        else {
                            if (Apointer < A.Count() - 1)
                            {
                                Apointer = Apointer + 1;
                            }
                            else
                            {
                                breakLoop = true;
                            }
                        }
                        break;

                }
                
            }
            return res;
        }


        public static int getMaxPair(int a, int b,int c)
        {
            if (a > b && a > c)
            {
                return 1;
            }
            else if (b > c)
            {
                return 2;
            }
            else {
                return 3;
            }
        }

        public static int getabs(int a,int b)
        {
            if (a - b >= 0)
            {
                return a - b;
            }
            else {
                return b - a;
            }
        }

    }

}

