public class Solution 
{
    public int[] ProductExceptSelf(int[] nums) 
    {
        int length=nums.Length;
        int[] result=new int[length];
        int temp=1;
        
        for(int i=0;i<length;i++)
        {
            result[i]=temp;
            temp*=nums[i];
        }
        temp=1;
        for(int i=length;i>0;i--)
        {
            result[i-1]*=temp;
            temp*=nums[i-1];
        }
        return result;
    }
}
