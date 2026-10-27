namespace HeroesVSMonsters.Models;

[Leather(10)]
[Gold(20)]
public class Dragon : Monster 
{
    public override int For => base.For + 1 ;
    public override int End => base.End + 1; 
    
    public Dragon () : base("The Dragon")
    {

    }
}
