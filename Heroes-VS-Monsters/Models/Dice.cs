using System.Security.Cryptography.X509Certificates;

namespace HeroesVSMonsters.Models;

public class Dice
{
    public static int GetCaracteristic()
    {
        Dice dice = new Dice(6);
        return Enumerable.Range(0,4)
                         .Select(i => dice.Next())
                         .OrderDescending()
                         .Take(3)
                         .Sum();
    }


    private int Maximum { get; }
    private readonly Random _random;
    public Dice(int maximum)
    {
        _random = new Random();
        Maximum = maximum;
    }

    public int Next()
    {
        return _random.Next(Maximum) + 1;
    }
}