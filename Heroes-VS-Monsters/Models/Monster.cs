namespace HeroesVSMonsters.Models;

public abstract class Monster : Living
{
    protected Monster(string name) : base(name)
    {
        
    }
    
}

public class Wolf : Monster 
{
    public override int End => base.End + 1;

    public Wolf () : base("the Wolf")
    {

    }
}

public class Orc : Monster 
{
    public override int For => base.For + 1;

    public Orc() : base("The Orc") 
    {

    }
}

public class Dragon : Monster 
{
    public override int For => base.For + 1 ;
    public override int End => base.End + 1; 
    
    public Dragon () : base("The Dragon")
    {

    }
}