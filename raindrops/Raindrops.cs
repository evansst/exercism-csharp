using System.Collections.Generic;

public static class Raindrops
{
    public static string Convert(int number)
    {
        var drops = "";
        if (number % 3 == 0)
        {
            drops += "Pling";
        }

        if (number % 5 == 0)
        {
            drops += "Plang";
        }

        if (number % 7 == 0)
        {
            drops += "Plong";
        }

        return drops != "" ? drops : number.ToString();
    }
}