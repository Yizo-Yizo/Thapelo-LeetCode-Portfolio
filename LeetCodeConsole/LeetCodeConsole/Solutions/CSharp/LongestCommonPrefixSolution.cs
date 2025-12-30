public class LongestCommonPrefixSolution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0 || strs == null)
        {
            return "";
        }

        Array.Sort(strs);

        string first = strs[0];
        string last = strs[strs.Length - 1];

        int i = 0;
        while (i < first.Length && i < last.Length && first[i] == last[i])
        {
            i++;
        }
        return first.Substring(0, i);
    }
}