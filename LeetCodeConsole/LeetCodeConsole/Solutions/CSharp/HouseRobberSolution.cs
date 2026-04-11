public class HouseRobberSolution
{
    public int Rob(int[] nums)
    {
        int n = nums.Length;

        if (n == 0) return 0;
        if (n == 1) return nums[0];
        if (n == 2) return Math.Max(nums[0], nums[1]);

        // We only need the previous two values (O(1) space)
        int prev2 = nums[0];        // dp[i-2]
        int prev1 = Math.Max(nums[0], nums[1]);  // dp[i-1]

        for (int i = 2; i < n; i++)
        {
            int current = Math.Max(prev1, prev2 + nums[i]);
            
            prev2 = prev1;   // shift forward
            prev1 = current;
        }

        return prev1;
    }
}