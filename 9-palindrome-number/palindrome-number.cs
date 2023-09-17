public class Solution {
    public bool IsPalindrome(int x) {

        if(x <0 ){
            return false;
        }
        int num = x;
        int invertedNum = 0;
        int digit = 0;
        while (num != 0){
            digit = num % 10;
            invertedNum = invertedNum*10 + digit;
            num /= 10;

        }
        return invertedNum == x;
    }
}