using System;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return false;
        }

        bool hasPuntuation = input[input.Length-1].Equals(".");
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        int count = 0;

        foreach(char c in alphabet)
        {
            foreach (char lit in input.ToLower())
            {
                if (c == lit)
                {
                    count++;
                    break;
                }
            }
        }

        if(count == 26 && !hasPuntuation)
        {
            return true;
        }
        else
        {
            if(count==27 && hasPuntuation)
            {
                return true;
            }
        }

        return false;
    }
}
