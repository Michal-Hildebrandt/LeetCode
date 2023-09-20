public class Solution {
    public string LongestCommonPrefix(string[] strs) {   
    int minLength =  strs.Min(s => s.Length);
    string shortest = strs.FirstOrDefault(s => s.Length == minLength);
    foreach(string str in strs){
        for (int j=0; j < minLength; j++){
            if (str[j] != shortest[j])
            {
            minLength =j;
            break;
            if (minLength == 0){
                break;
            }
            }
        } 
    }
        return shortest.Substring(0,minLength);
    }
}