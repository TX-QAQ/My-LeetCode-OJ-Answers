public class Solution 
{
    public int MissingNumber(int[] nums) 
    {
        int max=0;
        int sum=0;
        bool markZero=false;
        int length=nums.Length;
        for(int i=0;i<length;i++)
        {
            if(nums[i]==0) markZero=true;
            if(nums[i]>max) max=nums[i];
            sum+=nums[i];
        }
        int result=(int)max*(1+max)/2-sum;
        if(result==0 && markZero==true) result=length;
        return result;
    }
}
