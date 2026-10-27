namespace HeroesVSMonsters.Models;

[Leather(4)]
public class Wolf : Monster 
{
    public override int End => base.End + 1;

    public Wolf () : base("the Wolf")
    {

    }
}
