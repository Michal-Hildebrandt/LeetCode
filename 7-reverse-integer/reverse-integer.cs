public class Solution {
    public int Reverse(int x) {
     /*   
        non-modulo version

        char[] chr = x.ToString().ToCharArray();
        char[] rev = new char[chr.Length];
        int revInt;
        if (chr[0] == '-')
        {
            rev[0] = '-';
            for (int i = 0; i < chr.Length-1; i++)
            {
                rev[i+1] = chr[chr.Length - i-1];
            }
        }
        else
        {
            for (int i = 0; i < chr.Length; i++)
            {
                rev[i] = chr[chr.Length - i - 1];
            }
        }
    string str = new string(rev);
    try
    {
        revInt = Convert.ToInt32(str);
        return revInt;
    }
    catch (OverflowException e)
    { 
        revInt = 0;
        return revInt;
    }
    */

    int invertedNum = 0;
    int maxVal = int.MaxValue / 10;
    int minVal = int.MinValue / 10;


    while (x!=0){
        if (invertedNum > maxVal || invertedNum < minVal){
            return 0;
        }
        invertedNum = invertedNum*10 + x%10;    
        x /= 10;      
    }
        return invertedNum;
    } 
}   