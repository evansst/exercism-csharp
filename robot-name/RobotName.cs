using System.Collections.Generic;
using System.Security.Cryptography;

public class Robot
{
    private static RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
    private const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private static readonly List<string> All = new List<string>();

    public Robot() => Reset();

    public string Name { get; private set; }

    public void Reset()
    {
        var randomLetter1 = RandomLetter();
        var randomLetter2 = RandomLetter();
        var randomNumber = RandomNumber();
        Name = $"{randomLetter1}{randomLetter2}{randomNumber:000}";
        
        if (All.Contains(Name)) Reset();
        else All.Add(Name);
    }

    private static char RandomLetter()
    {
        byte[] randomLetter = new byte[1];
        rng.GetBytes(randomLetter);
        return alphabet[randomLetter[0] % 26];
    }

    private static int RandomNumber()
    {
        byte[] randomLetter = new byte[1];
        rng.GetBytes(randomLetter);
        return randomLetter[0] * 4 % 1000;
    }
}