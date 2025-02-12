namespace ObserverPattern01_AR.Business.Model;

public class Knight : IObserver
{
    public void React()
    {
        Console.WriteLine("Knight draws his sword!");
    }
}

public class Mage : IObserver
{
    private readonly DragonEventManager _dragonEventManager;
    
    public Mage(DragonEventManager dragonEventManager)
    {
        _dragonEventManager = dragonEventManager;
    }
    
    public void React()
    {
        if (_dragonEventManager.GetDragonPower() > 50)
        {
            Console.WriteLine("Mage casts a fireball!");    
        }
        else
        {
            Console.WriteLine("Mage uses a simple magic bolt.");
        }
    }
}

public class Merchant : IObserver
{
    public void React()
    {
        Console.WriteLine("Merchant hides behind a barrel!");
    }
}

public class 
