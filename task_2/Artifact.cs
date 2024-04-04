public class Artifact : InventoryDecorator
{
    public Artifact(IHero hero) : base(hero) { }

    public override string GetDescription()
    {
        return base.GetDescription() + ", Artifact";
    }

    public override int GetHealth()
    {
        return base.GetHealth() + 20; 
    }

    public override int GetStrength()
    {
        return base.GetStrength() + 2; 
    }
}
