class Solution
{
    //All number using 1 and 2 of length k

    //if k = 2
    // 11,12,21,22
    //if k=3
    //111,112,121.. 

    static void Main(string[] args)
    {
        Solution solution = new Solution();

        var result = solution.solve(2);
        Console.WriteLine(result.ToString());
    }
    public List<string> solve(int k)
    {
        List<string> result = new List<string>();
        helper(k, 0, string.Empty, result);
        return result;
    }
    public void helper(int n, int i, string final, List<string> result)
    {
        if (n == i)
        {
            Console.WriteLine(final + "\n");
            result.Add(final);
            return;
        }

        var temp = final + "1";
        helper(n, i + 1, temp, result);
        temp = final + "2";
        helper(n, i + 1, temp, result);

    }
}
