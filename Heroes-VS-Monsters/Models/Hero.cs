using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace HeroesVSMonsters.Models;

public class Hero : Living
{
    public Hero() : base("The hero")
    {        
    }

    public void Loot(Monster monster)
    {
        Type monsterType = monster.GetType();
        IEnumerable<LootAttribute> lootAttributes = monsterType.GetCustomAttributes<LootAttribute>();

        Console.WriteLine($"I loot a '{monsterType.Name}'");
        foreach(LootAttribute lootAttribute in lootAttributes)
        {
            Console.WriteLine($"I found {lootAttribute.Quantity} {lootAttribute.LootName}");
        }
        Console.WriteLine();
    }
}