public class Solution 
{
    public int TitleToNumber(string s) 
    {
        int sum=0;
        int length=s.Length;
        for(int i=0;i<length;i++)
        {
            sum+=(s[i]-64)*(int)Math.Pow(26,(length-i-1));
        }
        return sum;
    }
}
