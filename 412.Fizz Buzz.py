def change(n):
    if n%3 == 0:
        if n%5 == 0:
            n = "FizzBuzz"
        else:
            n = "Fizz"
        return n
    elif n %5 == 0:
        n = "Buzz"
        return n
    else:
        n = str(n)
        return n
        
class Solution(object):
    def fizzBuzz(self, n):
        """
        :type n: int
        :rtype: List[str]
        """
        return [change(x) for x in xrange(1,n+1)]
