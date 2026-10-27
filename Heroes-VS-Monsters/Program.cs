using HeroesVSMonsters.Model;

List<Monster> monstres = new List<Monster>
{
    new Monster(50, 10, "Gobelin"),
    new Monster(80, 15, "Orc"),
    new Monster(200, 40, "Dragon"),
    new Monster(120, 20, "Troll")
};

foreach (Monster m in monstres)
{
    Console.WriteLine($"{m.Nom} : endurance {m.Endurance}, force {m.Force}");
}

monstres[0].Attaquer(monstres[1]);
