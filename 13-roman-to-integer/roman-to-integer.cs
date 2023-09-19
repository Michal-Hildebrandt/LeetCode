public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char,int> mappedNumerals = new Dictionary<char,int>{
            {'M', 1000},

            {'D', 500},

            {'C', 100},

            {'L', 50},

            {'X', 10},

            {'V', 5},

            {'I', 1}
        };
        int result = 0;

        for( int i = 0; i < s.Length; i++){
            if(i+1 <s.Length && mappedNumerals[s[i]] <mappedNumerals[s[i+1]]){
                result -= mappedNumerals[s[i]];
            }else{
                result += mappedNumerals[s[i]];
            }
        }
        return result;
    }
}