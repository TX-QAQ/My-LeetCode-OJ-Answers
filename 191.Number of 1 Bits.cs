public class Solution 
{
    public int HammingWeight(uint n) 
    {
        int count=0;
        for(int i=0;i<32;i++)
        {
            if(n%2!=0)
            {
                n-=1;
                count++;
            }
            n/=2;
        }
        return count;
    }
}
