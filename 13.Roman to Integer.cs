public class Solution 
{
    public int RomanToInt(string s) 
    {
        int length=s.Length;
        if(length==1)
        {
            return ChangeSingleRomanIntoInt(s[0]);
        }
        else
        {
            int sum=0;
            int previousCharValue=ChangeSingleRomanIntoInt(s[0]);
            int charCount=1;
            for(int i=1;i<length-1;i++)
            {
                int currentCharValue=ChangeSingleRomanIntoInt(s[i]);
                if(currentCharValue==previousCharValue)
                {
                    charCount++;
                    //if(i==length-1){sum+=charCount*previousCharValue;}
                    continue;
                }
                if(currentCharValue<previousCharValue)
                {
                    sum+=charCount*previousCharValue;
                    previousCharValue=currentCharValue;
                    charCount=1;
                    continue;
                }
                sum=sum-charCount*previousCharValue;//+currentCharValue;
                previousCharValue=currentCharValue;
                charCount=1;
            }
            //when i=length-1
            {
                int currentCharValue=ChangeSingleRomanIntoInt(s[length-1]);
                if(currentCharValue==previousCharValue)
                {
                    charCount++;
                    sum+=charCount*previousCharValue;
                }
                else if(currentCharValue<previousCharValue)
                {
                    sum=sum+charCount*previousCharValue+currentCharValue;
                }
                else
                {
                    sum=sum-charCount*previousCharValue+currentCharValue;
                }
            }
            return sum;
        }
    }
    
    public int ChangeSingleRomanIntoInt(char c)
    {
        switch(c)
        {
            case 'I':
                return 1;
            case 'V':
                return 5;
            case 'X':
                return 10;
            case 'L':
                return 50;
            case 'C':
                return 100;
            case 'D':
                return 500;
            case 'M':
                return 1000;
            default:
                return 0;
        }
    }
}
