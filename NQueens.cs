using System.Text.Json.Nodes;

class Solution
{
    //{5,7,2} -> 7=> {5,2} {5} {7} {2}....

    static void Main(string[] args)
    {
        Solution solution = new Solution();

        solution.NQueens(4);
    }
    public void NQueens(int n)
    {
        int[][] board = new int[n][];

        for (int i = 0; i < n; i++)
        {
            board[i] = new int[n];
        }
        helperNqueen(board, 0);
    }
    public void helperNqueen(int[][] board, int r)
    {
        if (r == board.Length)
        {
            Console.WriteLine("=====================================================================");

            for (int i = 0; i < board.Length; i++)
            {
                Console.WriteLine(string.Join(",", board[i]));
            }
            Console.WriteLine("=====================================================================");

            return;
        }
        for (var col = 0; col < board.Length; col++)
        {
            if (isSafeToPlace(board, r, col))
            {
                board[r][col] = 1;
                helperNqueen(board, r + 1);
                board[r][col] = 0;
            }
        }
    }
    bool isSafeToPlace(int[][] board, int r, int c)
    {
        //check in top direction, top , top left , top right
        // top
        for (var i = r - 1; i > -1; i--)
        {
            if (board[i][c] == 1)
            {
                return false;
            }
        }

        //top left
        for (int i = c-1, j = r-1; i > -1 && j > -1; i--, j--)
        {
            if (board[j][i] == 1)
            {
                return false;
            }
        }

        //top right
        for (int i = r - 1, j = c + 1; i > -1 && j < board.Length; i--, j++)
        {
            if (board[i][j] == 1)
            {
                return false;
            }
        }

        return true;
    }

}
