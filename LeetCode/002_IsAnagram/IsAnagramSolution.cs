public class IsAnagramSolution {
    public bool IsAnagram(string s, string t) {

        if (s.Length != t.Length)
        {
            return false;
        }


        var sCharArray = s.ToCharArray();
        var tCharArray = t.ToCharArray();  

        Array.Sort(sCharArray);
        Array.Sort(tCharArray);

      return sCharArray.SequenceEqual(tCharArray);
    }
}