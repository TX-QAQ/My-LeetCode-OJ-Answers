from re import sub
class Codec:
    """
    encode the str char by char, repeating char will be changed into \n\c : c is the char while n is the number
    for example: aaabbbbc is encoded into \3\a\4\bc
    Some questions left for inspiring thinking:
        1.Why we don't encode them as \c\n ?
        2.Is so much "\" really needed?
    
    """
    def encode(self, longUrl):
        sub1 = sub(r"\\", r"\\\\", longUrl)
        return sub(r'([^\\])\1+', lambda m: "\\" + str(len(m.group(0))) + "\\" + m.group(1), sub1)

    def decode(self, shortUrl):
        sub1 = sub(r'\\(\d+)\\(.)', lambda m: m.group(2) * int(m.group(1)), shortUrl)
        return sub(r"\\\\", r"\\", sub1)
