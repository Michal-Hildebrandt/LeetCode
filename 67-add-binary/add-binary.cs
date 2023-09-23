public class Solution {
    public string AddBinary(string a, string b) {

StringBuilder result = new StringBuilder();
int carry = 0;
int i = a.Length - 1;
int j = b.Length - 1;

while (i >= 0 || j >= 0)
{
    //substract "int from string"
    carry += (i >= 0 ? a[i] - 48 : 0);
    carry += (j >= 0 ? b[j] - 48 : 0);

    // add 0 or 1
    result.Insert(0, carry % 2);
    carry = carry / 2;
    i--;
    j--;
}
if (carry == 1){
    result.Insert(0,carry);
}
        return result.ToString();
    }
}