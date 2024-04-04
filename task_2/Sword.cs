public class Sword : InventoryDecorator
{
    public Sword(IHero hero) : base(hero) { }

    public override string GetDescription()
    {
        return base.GetDescription() + ", Sword";
    }

    public override int GetStrength()
    {
        return base.GetStrength() + 5; 
    }
}
