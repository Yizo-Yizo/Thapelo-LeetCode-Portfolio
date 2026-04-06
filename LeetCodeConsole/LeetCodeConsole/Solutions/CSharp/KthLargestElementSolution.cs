public class KthLargestElementSolution
{
    public int FindKthLargest(int[] nums, int k) 
    {
        int count = 1;
        int result = 0;

        Array.Sort(nums);
        Array.Reverse(nums);

        if (nums.Length == 1)
        {
            return nums[0];
        }
        else if (nums.Length == 2 && k == 1)
        {
            return nums[0];
        }
        else if (nums.Length == 2 && k == 2)
        {
            return nums[1];
        }

        for (int i = 1; i < nums.Length; i++)
        {
            if (k == nums.Length)
            {
                result = nums[nums.Length - 1];
            }  
            if (count == k) 
            {
                result = nums[i-1];
                break;
            }
            if (nums[i-1] >= nums[i])
            {
                count++;
            }
            
        }

        return result;
    }
}