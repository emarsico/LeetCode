

 // O(n) Computational Complexity
// 2/2/24


public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int entireProduct = 1;
        int zeroProduct = 0;
        int[] answer = new int[nums.Length];

        // Get the product of all of the nums
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == 0)
            {
                zeroProduct = entireProduct;
                entireProduct *= nums[i];
            }
            else
            {
                entireProduct *= nums[i];
                zeroProduct *= nums[i];
            }
        }

        // Fill answer will except self products
        for(int i = 0; i < answer.Length; i++)
        {
            if(nums[i] != 0)
            {
                answer[i] = (entireProduct / nums[i]);
            }
            else
            {
                answer[i] = zeroProduct;
            }
        }

        return answer;
    }
}