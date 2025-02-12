namespace ObserverPattern01_AR.Business.Model;

public class DragonEventManager
{
    private readonly List<IObserver> _observers = new List<IObserver>();
    private int _dragonPower;
    
    public void AddObserver(IObserver observer)
    {
        _observers.Add(observer);
    }
    
    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    private void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.React();
        }
    }
    
    public int GetDragonPower()
    {
        return _dragonPower;
    }

    public void DragonAttacks(int dragonPower)
    {
        Console.WriteLine($"A Dragon appears! Dragon attacks with power {dragonPower}!");
        _dragonPower = dragonPower;
        NotifyObservers();
    }
}
