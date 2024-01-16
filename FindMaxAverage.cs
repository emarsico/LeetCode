

 // Time Complexity O(n)
// 1/16/24

public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        double windowTotal = 0;

        for(int i = 0; i < k; i++)   // Obtain the original window total
        {
            windowTotal += nums[i];
        }

        double largestSubarray = (windowTotal / k);

        if(k == nums.Length)    // Return original window max
        {
            return largestSubarray;
        }

        // Note that i points to the front of the window
        for(int i = k; i < nums.Length; i++)   // Shift the window until the end is reached, updating the maximum
        {
            windowTotal -= nums[i-k];
            windowTotal += nums[i];

            if((windowTotal / k) > largestSubarray)
            {
                largestSubarray = (windowTotal / k);
            }
        }

        return largestSubarray;
    }
}

/*

n = 10
k = 3

3
[i - k]

4

*/