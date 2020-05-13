class Solution {
    public List<int> plusOne(List<int> A) {
       List<int> res = new List<int>();
            int carry = 1;
            for (int i = A.Count() - 1; i >= 0; i--) {
                int temp = A[i] + carry;
                if (temp < 10)
                {
                    res.Add(temp);
                    carry = 0;
                }
                else {
                   
                    res.Add(temp % 10);
                    carry = temp / 10;

                }

            }

            if (carry > 0) {
                res.Add(carry);
            }
            res.Reverse();
             for (int i = 0; i < res.Count();) {
                if (res[i] == 0)
                {
                    res.RemoveAt(i);
                }
                else {
                    break;
                }
            }
            return res;
    }
}
