using System.Reflection.Metadata.Ecma335;

public class ContainsDuplicateSolution
{
    public bool ContainsDuplicate(int[] nums)
    {
        Dictionary<int, int> freq = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            if (!freq.ContainsKey(num))
            {
                freq[num] = 0;
                
            }
            freq[num]++;
        }

        return freq.Values.Any( v => v >1 );
    }
}