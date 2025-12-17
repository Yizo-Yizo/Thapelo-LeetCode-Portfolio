public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int sum = 0;
        int[] indecies = new int[2];

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                sum = nums[i] + nums[j];
                if (target == sum){
                    indecies[0] = i;
                    indecies[1] = j;
                    break;
                }
                    
                 
            }

            if (target == sum)
                break;
        }
        return indecies;
    }
}