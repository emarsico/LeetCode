

 // Top 59.44% Runtime
// 1/11/24


public class Solution {
    public int[] CountBits(int n) {
        int[] ans = new int[n+1];
        
        for(int i = 1; i < ans.Length; i++)
        {
            ans[i] = ans[i/2] + i%2;
        }

        return ans;
    }
}

/*
0   0
1   1
2   1
3   2
4   1
5   2
6   2
7   3

*/