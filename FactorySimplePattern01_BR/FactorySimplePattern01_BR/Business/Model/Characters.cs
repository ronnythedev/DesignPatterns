namespace FactoryPattern_Simple01_BR.Business.Model;

public class Wizard
{
    public string PerformAction() => "Wizard ready! Casting a fireball...";
}

public class Knight
{
    public string PerformAction() => "Knight ready! Charging into battle...";
}

public class Rogue
{
    public string PerformAction() => "Rogue ready! Sneaking in the shadows...";
}
