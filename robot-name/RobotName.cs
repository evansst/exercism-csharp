using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

public class Robot
{
    private string _name;
    private static RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
    private const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private static List<string> All = new List<string>();

    public string Name
    {
        get
        {
            if(_name == null) Reset();
            return _name;
        }
    }

    public void Reset()
    {
        byte[] randomNumbers = new byte[5];
        rng.GetNonZeroBytes(randomNumbers);
        var firstLetter = alphabet[randomNumbers[0] % 26];
        var secondLetter = alphabet[randomNumbers[1] % 26];
        var one = randomNumbers[2] % 10;
        var two = randomNumbers[3] % 10;
        var three = randomNumbers[4] % 10;
        _name = firstLetter.ToString() + secondLetter + one + two + three;
        
        if (All.Contains(_name)) Reset();
        else All.Add(_name);
    }
}