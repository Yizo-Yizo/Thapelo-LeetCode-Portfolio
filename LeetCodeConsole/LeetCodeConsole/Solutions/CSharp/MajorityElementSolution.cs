public class MajorityElementSolution
{
    public int MajorityElement(int[] nums) 
    {
        int majorityElementCount = 0;
        int majorityElement = 0;

        Dictionary<int, int> numsCount = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (numsCount.ContainsKey(num))
            {
                numsCount[num]++;
            }
            else
            {
                numsCount[num] = 1;
            }
        }

        foreach (var count in numsCount)
        {
            if (count.Value > majorityElementCount)
            {
                majorityElementCount = count.Value;
                majorityElement = count.Key;
            }
        }

        return majorityElement;
    }
}