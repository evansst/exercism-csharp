using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml;

public static class NucleotideCount
{
    private static Dictionary<char, int> _Seed =>
        new Dictionary<char, int>
        {
            {'A', 0}, {'C', 0}, {'G', 0}, {'T', 0},
        };

    public static IDictionary<char, int> Count(string sequence)
    {
        try
        {
            return sequence.Aggregate(_Seed, (dictionary, c) =>
            {
                dictionary[c]++;
                return dictionary;
            });
        }
        catch (KeyNotFoundException _e)
        {
            throw new ArgumentException("Those aren't nucleotides!");
        }
    }
}