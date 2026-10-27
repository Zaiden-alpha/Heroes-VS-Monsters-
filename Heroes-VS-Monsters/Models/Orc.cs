namespace HeroesVSMonsters.Models;

[Gold(6)]
public class Orc : Monster 
{
    public override int For => base.For + 1;

    public Orc() : base("The Orc") 
    {

    }
}
