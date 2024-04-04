using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to our RPG game!");
        Console.WriteLine("First, choose the type of hero:");
        Console.WriteLine("1 - Warrior");
        Console.WriteLine("2 - Mage");
        Console.WriteLine("3 - Paladin");

        string heroType = Console.ReadLine();

        IHero hero;
        switch (heroType)
        {
            case "1":
                hero = new Warrior();
                break;
            case "2":
                hero = new Mage();
                break;
            case "3":
                hero = new Paladin();
                break;
            default:
                Console.WriteLine("Invalid choice. A Warrior will be created.");
                hero = new Warrior();
                break;
        }

        while (true)
        {
            Console.WriteLine("Choose inventory for your hero:");
            Console.WriteLine("1 - Armor");
            Console.WriteLine("2 - Sword");
            Console.WriteLine("3 - Artifact");
            Console.WriteLine("4 - Finish inventory selection");

            string inventoryType = Console.ReadLine();

            if (inventoryType == "4")
            {
                break;
            }

            switch (inventoryType)
            {
                case "1":
                    hero = new Armor(hero);
                    break;
                case "2":
                    hero = new Sword(hero);
                    break;
                case "3":
                    hero = new Artifact(hero);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Armor will be added.");
                    hero = new Armor(hero);
                    break;
            }
        }

        Console.WriteLine($"Your hero: {hero.GetDescription()}");
        Console.WriteLine($"Health: {hero.GetHealth()}");
        Console.WriteLine($"Strength: {hero.GetStrength()}");
    }
}