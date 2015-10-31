public class Solution 
{
    public int SingleNumber(int[] nums) 
    {
        int s=0;
        for(int i=0;i<nums.Length;i++) s^=nums[i];
        return s;
    }
}
