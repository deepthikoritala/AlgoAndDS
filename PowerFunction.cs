using System.Text.Json.Nodes;

class Solution
{
    //pow(2,5)= 2*2*2*2*2 = 32

    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Console.WriteLine(solution.Power(4, 3));
    }
    public long Power(int n, int k)
    {

        if (k == 0) { return 1; }

        //optimized approach
        var temp = Power(n, k / 2);
        if (k % 2 == 0)
        {
            return temp * temp;
        }
        else
        {
            return temp * temp * n;
        }

        ////brute force

        //return Power(n, k - 1) * n;
    }

}
