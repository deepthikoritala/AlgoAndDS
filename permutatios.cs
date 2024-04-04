class Solution {
    public List<List<int>> permute(List<int> A) {
         List<List<int>> result = new List<List<int>>();
            permuterecur(A,new List<int>() { },ref result);
            return result;
    }
      public void permuterecur(List<int> subarr,List<int> final,ref List<List<int>> result)
        {
            if (subarr.Count() == 0)
            {
                result.Add(new List<int>(final));
            }
            else {

                for (int i = 0; i < subarr.Count(); i++) {
                    List<int> finaltemp = new List<int>(final);
                    finaltemp.Add(subarr[i]);

                    List<int> temp = new List<int>(subarr);
                    temp.RemoveAt(i);
                    permuterecur(temp,finaltemp,ref result);
                }
            
            }

           
        }
}
