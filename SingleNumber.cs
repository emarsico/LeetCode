

 // Top 94.25% Runtime
// 1/15/24

public class Solution {
    public int SingleNumber(int[] nums) {
        int bitVector = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            bitVector = bitVector ^ nums[i];
        }

        return bitVector;
    }
}

/*
[4,1,2,1,2]

bitVector = 0 ^ 4 = 4   100
bitVector = 4 ^ 1 = 5   101
bitVector = 5 ^ 2 = 7   111
bitVector = 7 ^ 1 = 6   110
bitVector = 6 ^ 2 = 4   100
bitVector = 4.  100 == 4

*/