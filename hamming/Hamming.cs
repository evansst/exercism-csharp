using System;
using System.Linq;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand) =>
        firstStrand.Length == secondStrand.Length
            ? firstStrand.Where((t, i) => t != secondStrand[i]).Count()
            : throw new ArgumentException("Arguments must have the same length.");
}