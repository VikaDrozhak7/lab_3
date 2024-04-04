public class Armor : InventoryDecorator
{
    public Armor(IHero hero) : base(hero) { }

    public override string GetDescription()
    {
        return base.GetDescription() + ", Armor";
    }

    public override int GetHealth()
    {
        return base.GetHealth() + 50; 
    }
}
