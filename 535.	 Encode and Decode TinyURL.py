from re import sub
class Codec:

    def encode(self, longUrl):
        sub1 = sub(r"\\", r"\\\\", longUrl)
        return sub(r'([^\\])\1+', lambda m: "\\" + str(len(m.group(0))) + "\\" + m.group(1), sub1)

    def decode(self, shortUrl):
        sub1 = sub(r'\\(\d+)\\(.)', lambda m: m.group(2) * int(m.group(1)), shortUrl)
        return sub(r"\\\\", r"\\", sub1)
