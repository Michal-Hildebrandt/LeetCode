public class Solution {
    public int LengthOfLastWord(string s) {
        s = s.TrimStart().TrimEnd();
        string[] words = s.Split(' ');
        return words[words.Length-1].Length;
    }
}