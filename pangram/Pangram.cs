using System;
using System.Collections.Generic;
using System.Linq;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        var upper = input.ToUpper();
        var charArray = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        return charArray.All(upper.Contains);
    }
}