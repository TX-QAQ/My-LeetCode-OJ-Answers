class Solution 
{
public:
    int addDigits1(int num) 
    {
        if (num>9)
            num = addDigits(num/10 + num%10);
        return num;
    }
    
    int addDigits2(int num) 
    {
        return num == 0 ? num : (num%9 == 0 ? 9 : num%9);
    }
    
    int addDigits(int num) 
    {
        return (num-1)%9+1;
    }
};
