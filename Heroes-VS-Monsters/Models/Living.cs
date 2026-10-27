namespace HeroesVSMonsters.Models;

public abstract class Living
{
    private static int GetModifier(int caracteristic)
    {
        return caracteristic < 5 ? -1 :
               caracteristic < 10 ? 0 :
               caracteristic < 15 ? 1 : 2;
    }

    private readonly Dice _dice4;
    private readonly Dice _dice6;

    public int End { get; }
    public int For { get; }
    public int Life { get; private set; }
    public string Name { get; }
    public bool IsAlive => Life > 0; 

    public Living(string name)
    {
        //init dice
        _dice4 = new Dice(4);
        _dice6 = new Dice(6);
        //set the name
        Name = name;
        //set caracteristics
        End = Dice.GetCaracteristic();
        For = Dice.GetCaracteristic();
        Life = End + GetModifier(End);
    }

    internal void Rest()
    {
        if(this is Monster)
        {
            throw new InvalidOperationException("A monster can't rest.");
        }

        Life = End + GetModifier(End);
    }

    public void Attack(Living target)
    {
        int damage = _dice4.Next() + GetModifier(For);
        target.Life -= damage;
    }

    public override string ToString()
    {
        return $"I'm '{Name}' and i have {End} in End and {For} in For";
    }
}
