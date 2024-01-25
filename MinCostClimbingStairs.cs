

 // O(n) Computational Complexity
// 1/25/24


public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        int option1 = cost[cost.Length-2];
        int option2 = cost[cost.Length-1];

        for(int i = cost.Length-3; i > -1; i--)
        {
            if(option1 < option2)
            {
                cost[i] = option1 + cost[i];
            }
            else
            {
                cost[i] = option2 + cost[i];
            }

            option1 = cost[i];
            option2 = cost[i+1];
        }

        return (option1 < option2 ? option1 : option2);
    }
}
