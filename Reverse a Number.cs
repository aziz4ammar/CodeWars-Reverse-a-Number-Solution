using System;

public class Kata
{
    public int ReverseNumber(int n)
    {
        bool isNegative = n < 0;
        n = Math.Abs(n);
        
        int reversed = 0;
        while (n > 0)
        {
            int digit = n % 10;
            reversed = reversed * 10 + digit;
            n /= 10;
        }
        
        return isNegative ? -reversed : reversed;
    }
}