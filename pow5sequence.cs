class Solution {
    public int solve(int A) {
        int res = 0;

            int[] pow5 = new int[14];

            for (int i = 0; i < 14; i++) {
                pow5[i] =(int)Math.Pow(5,i);
            }
            List<int> binary = new List<int>();
            while (A > 0) {
                binary.Add(A%2);
                A = A / 2;
            }
            for (int i = binary.Count() - 1; i >= 0; i--) {
                res = res + pow5[i+1] * binary[i];
            }

            return res;
    }
}
