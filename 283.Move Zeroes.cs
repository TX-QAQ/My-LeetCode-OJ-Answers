public class Solution 
{
    public void MoveZeroes(int[] nums) 
    {
        
        for(int i=0;i<nums.Length-1;i++)
        {
            if(nums[i]==0)
            {
                for(int k=i;k<nums.Length;k++)
                {
                    if(nums[k]!=0)
                    {
                        nums[i]=nums[k];
                        nums[k]=0;
                        break;
                    }
                    
                }
                
            }
        }
    }
}
