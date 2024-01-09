// Top 61.75% Runtime

public class Solution {
    public void MoveZeroes(int[] nums) {
        int start = 0;
        for(int i = 0; i < nums.Length; i++)
        {
           if(nums[i] != 0)
           {
               (nums[start], nums[i]) = (nums[i], nums[start]);
               start++;
           } 
        }
    }
}

/*


0 1 3 0 4
0 1 3 0 4
1 0 3 0 4  start = 1
1 3 0 0 4  start = 2
1 3 4 0 0


public class Solution {
    public void MoveZeroes(int[] nums) {
        int zerosMoved = 0;
        int i = 0;
        while(i < nums.Length - zerosMoved)
        {
            if(nums[i] == 0)
            {
                int j = i;
                while(j < (nums.Length - zerosMoved - 1))
                {
                    nums[j] = nums[j+1];
                    j++;
                }
                nums[j] = 0;
                zerosMoved++;
                i--;
            }
            i++;
        }
    }
}

// 0 0 1
// 0 1 0
// 1 0 0

public class Solution {
    public void MoveZeroes(int[] nums) {
        int correctNums = 0;
        while(correctNums + 1 < nums.Length)
        {
            int index = 0 + correctNums;
            if(nums[index] == 0 && index < nums.Length)
            {
                int temp = nums[index+1];
                nums[index+1] = nums[index];
                nums[index] = temp;
            }

            for(int b = nums.Length - 1; b > correctNums; b--)
            {
                if(b > 0 && nums[b-1] == 0)
                {
                    int temp = nums[b-1];
                    nums[b-1] = nums[b];
                    nums[b] = temp;
                }
            }
            correctNums++;
        }
    }
}

// 0 1 3 0 4
// 1 0 3 0 4
// 1 3 0 0 4
// 1 3 0 0 4
// 1 3 0 4 0

// 0 1 3 0 4

// 1 0 3 0 4
// 1 3 0 4 0

// 1 3 4 0 0

*/