namespace ObserverPattern01_BR.Business.Model;

public class DragonEventManager
{
    private readonly Knight _knight;
    private readonly Mage _mage;
    private readonly Merchant _merchant;
    
    public DragonEventManager(Knight knight, Mage mage, Merchant merchant)
    {
        _knight = knight;
        _mage = mage;
        _merchant = merchant;
    }

    public void DragonAttacks(int dragonPower)
    {
        // Here is the problem: DragonEventManger is responsible for all what happens when a dragon attacks.
        // This breaks the Single Responsibility Principle.
        // Imagine if the game has 100 different characters, each with different reactions to a dragon attack!
        Console.WriteLine($"A Dragon appears! Dragon attacks with power {dragonPower}!");
        _knight.React();
        _mage.React(dragonPower);
        _merchant.React();
    }
}

public class Knight
{
    public void React()
    {
        Console.WriteLine("Knight draws his sword!");
    }
}

public class Mage
{
    public void React(int dragonPower)
    {
        if (dragonPower > 50)
        {
            Console.WriteLine("Mage casts a fireball!");    
        }
        else
        {
            Console.WriteLine("Mage uses a simple magic bolt.");
        }
    }
}

public class Merchant
{
    public void React()
    {
        Console.WriteLine("Merchant hides behind a barrel!");
    }
}