public class Solution {
    public bool IsPalindrome(int x) {

        bool isPalindrome = true;
        char[] number = x.ToString().ToCharArray();
        char[] invertedNumber = new char[number.Length];
        for(int i = 0; i < number.Length; i++){
            invertedNumber[i] = number[number.Length-1-i];
             if( invertedNumber[i] != number[i]){
                isPalindrome = false;
            }
        }
        return isPalindrome;
    }
}