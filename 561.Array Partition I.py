class Solution(object):
    def arrayPairSum(self, nums):
        """
        :type nums: List[int]
        :rtype: int
        """
       
        nums.sort()
        return sum(nums[::2])
        
"""
    We can consider this problem recursively.
    Firstly, from the given list we choose the minimum pair ( min(nums), x ),
    apparently the value min(m, x) of this pair is min(nums) no matter what the x is .
    So the x is simplely 'wasted', it's obvious that we shall waste the secondary minimum.
    And then we start to choose another minimum pair from the rest numbers of the list.
    So in conclusion,we divide the list into pairs by every adjoining two numbers and the value of a pair is the smaller one.
    It's clear now we sort the list first and return the summation of first number in every two numbers.
"""
