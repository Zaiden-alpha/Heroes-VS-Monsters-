namespace HeroesVSMonsters.Models;


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        Hero hero = new();
        Console.WriteLine(hero);

        hero.Loot(new Wolf());
        hero.Loot(new Wolf());
        hero.Loot(new Orc());
        hero.Loot(new Orc());
        hero.Loot(new Dragon());
        hero.Loot(new Dragon());
    }
}
