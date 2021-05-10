using System.Collections.Generic;
using System.Linq;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        string lower = word.ToLower();
        return lower.Any(c => char.IsLetter(c) && lower.IndexOf(c) != lower.LastIndexOf(c));
    }
}