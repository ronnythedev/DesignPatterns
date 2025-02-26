namespace FactoryPattern_Simple01_AR.Business.Model;

public class Wizard : ICharacter
{
    public void PerformAction()
    {
        Console.WriteLine("Wizard ready! Casting a fireball...");
    }
}

public class Knight : ICharacter
{
    public void PerformAction()
    {
        Console.WriteLine("Knight ready! Charging into battle...");
    }
}

public class Rogue : ICharacter
{
    public void PerformAction()
    {
        Console.WriteLine("Rogue ready! Sneaking in the shadows...");
    }
}