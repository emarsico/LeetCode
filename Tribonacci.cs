


 // O(n) Computational Complexity
// 1/23/24


public class Solution {
    public int Tribonacci(int n) {
        int n1 = 0;
        int n2 = 1;
        int n3 = 1;

        if(n == 0)
        {
            return 0;
        }
        else if(n <= 2)
        {
            return 1;
        }

        return RecursiveTribonacci(n1, n2, n3, n, 3);
    }


    public int RecursiveTribonacci(int n1, int n2, int n3, int n, int currentInd)
    {
        if(currentInd == n)
        {
            return (n1 + n2 + n3);
        }
        
        return RecursiveTribonacci(n2, n3, n1+n2+n3, n, (++currentInd));
    }
}

/*
0, 1, 1, 2, 4, 7, 13, 24

1, 2, 4
*/