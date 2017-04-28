def search_larger(target_list, n):
    for item in target_list:
        if item > n:
            return item
    return -1
class Solution(object):
    def nextGreaterElement(self, findNums, nums):
        """
        :type findNums: List[int]
        :type nums: List[int]
        :rtype: List[int]
        """
        return [search_larger(nums[nums.index(num):], num) for num in findNums]

#An ordinary solution
