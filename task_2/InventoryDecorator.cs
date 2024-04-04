public abstract class InventoryDecorator : IHero
{
    protected IHero hero;

    public InventoryDecorator(IHero hero)
    {
        this.hero = hero;
    }

    public virtual string GetDescription()
    {
        return hero.GetDescription();
    }

    public virtual int GetHealth()
    {
        return hero.GetHealth();
    }

    public virtual int GetStrength()
    {
        return hero.GetStrength();
    }
}
