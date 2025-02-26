namespace FactoryPattern_Simple01_BR.Business.Model;

public class Wizard
{
    public string PerformAction() => "Wizard created! Casting a fireball...";
}

public class Knight
{
    public string PerformAction() => "Knight created! Charging into battle...";
}

public class Rogue
{
    public string PerformAction() => "Rogue created! Sneaking in the shadows...";
}
