public class Solution 
{
    public int SearchInsert(int[] nums, int target) 
    {
        int length=nums.Length;
        for(int i=0;i<length;i++)
        {
            if(target<=nums[i])
            {
                return i;
            }
        }
        return length;
    }
}
