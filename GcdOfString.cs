public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        if(str2.Length > str1.Length)
        {
            (str2, str1) = (str1, str2);
        }
        
        int maxLength = str2.Length;

        if(maxLength == 0 || str1.Length == 0)
        {
            return "";
        }

        int gcd = GetGCD(str1.Length, str2.Length);
        string minStr = str2.Substring(0, gcd);
        
        if(str1.IndexOf(minStr) == 0 && str1.Contains(String.Concat(Enumerable.Repeat(minStr, (str1.Length/minStr.Length)))))
        {
            for(str1.Length == )

            return minStr;
        }

        return "";
    }

    // num1 > num2
    public int GetGCD(int num1, int num2)
    {
        while(num1 != 0 && num2 != 0)
        {
            if(num1 > num2)
            {
                num1 = (num1%num2);
            }
            else
            {
                num2 = (num2%num1);
            }
        }

        return num2 == 0 ? num1 : num2;
    }
}

// ABABAB  ABAB
// "TAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXX" 45
// "TAUXXTAUXXTAUXXTAUXXTAUXX" 25

// "TAUXX"

// 45 % 25
// 25 % 20
// 20 % 5