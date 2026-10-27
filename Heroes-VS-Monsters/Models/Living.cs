namespace HeroesVSMonsters.Models;

public abstract class Living
{
    private static int GetModifier(int characteristic)
    {
        return characteristic < 5 ? -1 :
               characteristic < 10 ? 0 :
               characteristic < 15 ? 1 : 2;
    }

    private readonly Dice _dice4;
    private readonly Dice _dice6;

    public int End { get; }
    public int For { get; }
    public int Life { get; private set; }
    public string Name { get; }

    public Living(string name)
    {
        _dice4 = new Dice(4);
        _dice6 = new Dice(6);
        Name = name;
        End = Dice.GetCharacteristic();
        For = Dice.GetCharacteristic();
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

    public void Attack(Living living)
    {
        int damage = _dice4.Next() + GetModifier(For);
    }

    public override string ToString()
    {
        return $"I'm '{Name}' and i have {End} in End and {For} in For";
    }
}
