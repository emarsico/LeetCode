

 // O(n) Computational Complexity
// 1/22/24

public class Solution {
    public int PivotIndex(int[] nums) {
        int arrTotal = 0;
        int leftTotal = 0;

        // Count the total in the arr
        arrTotal = nums.Sum();

        for(int i = 0; i < nums.Length; i++)
        {
            int rightTotal = (arrTotal - nums[i] - leftTotal);

            if(rightTotal == leftTotal)
            {
                return i;
            }

            leftTotal += nums[i];
        }

        return -1;
    }
}

/*
6
[1, 2, 3]
*/
