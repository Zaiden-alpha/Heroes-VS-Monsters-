namespace HeroesVSMonsters.Models;

[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
public abstract class LootAttribute : Attribute
{
    private readonly Dice _dice;
    private readonly int _maxQuantity;
    private int? _quantity;
    public int Quantity => _quantity ??= _dice.Next();

    public string LootName { get; }

    public LootAttribute(string lootName, int maxQuantity)
    {
        if(maxQuantity < 1)
            throw new InvalidOperationException("The quantity of loot must be greater than 0");

        _dice = new Dice(maxQuantity);
        _maxQuantity = maxQuantity;
        LootName = lootName;
    }
}