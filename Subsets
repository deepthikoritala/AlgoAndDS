using System.Text.Json.Nodes;

class Solution
{
   //{5,7,2} -> 7=> {5,2} {7}

    static void Main(string[] args)
    {
        Solution solution = new Solution();

        solution.solve();
    }
    public void solve()
    {
        List<List<int>> result = new();
        List<int> input = new List<int>() { 5, 7, 2 };
        helper(input, 0, 7, new List<int>(), result);
    }
    public void helper(List<int> input, int i, int sum, List<int> currentArr, List<List<int>> result)
    {
        if (input.Count == i)
        {
            if (sum == currentArr.Sum())
            {
                result.Add(new List<int>(currentArr));
                Console.WriteLine(string.Join(",", currentArr));
            }
            return;
        }

        var arr = new List<int>(currentArr);
        helper(input, i + 1, sum, arr, result);
        arr.Add(input[i]);
        helper(input, i + 1, sum, arr, result);
    }
}
