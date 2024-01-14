

 // Top 21.08% Runtime (ouch)
// 1/14/24

public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        IList<IList<int>> answer = new List<IList<int>>();
        IList<int> unique1 = new List<int>();
        IList<int> unique2 = new List<int>();

        for(int i = 0; i < nums1.Length; i++)
        {
            if(!nums2.Contains(nums1[i]) && !unique1.Contains(nums1[i]))    // unique num found
            {
                unique1.Add(nums1[i]);
            }
        }

        for(int i = 0; i < nums2.Length; i++)
        {
            if(!nums1.Contains(nums2[i]) && !unique2.Contains(nums2[i]))    // unique num found
            {
                unique2.Add(nums2[i]);
            }
        }

        answer.Add(unique1);
        answer.Add(unique2);

        return answer;
    }
}