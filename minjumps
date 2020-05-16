class Solution {
    public int solve(List<int> A) {
   int res = 0;
            int i = 0;
            while (i < A.Count()-1) {
                int reqindex = A[i];
                if (reqindex < 1) {
                    return -1;
                }
                if (A[i] > 1) {
                    if (i + A[i] < A.Count()-1)
                    {
                        reqindex = getMax(A.GetRange(i+1, A[i]),i);
                       
                    }
                    else {
                       
                        res = res + 1;
                        break;
                    }
                }
                i = i + reqindex;
                res = res + 1;
            }

            return res;
    }
      int getMax(List<int> A,int currentindex) {
           int res = -1,resindex=0;
            for (int i=0;i<A.Count();i++) {
                if (res <currentindex+i+ A[i]) {
                    res = currentindex + i+ A[i];
                    resindex = i;
                }
            }
            return resindex+1;
            }
}
