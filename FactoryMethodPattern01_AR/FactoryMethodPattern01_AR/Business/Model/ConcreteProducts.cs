namespace FactoryMethodPattern01_AR.Business.Model;

public class Espresso : IDrink
{
    public string GetDescription()
    {
        return "Espresso brewed with bold flavor!";
    }
}

public class Latte : IDrink
{
    public string GetDescription()
    {
        return "Latte crafted with steamed milk!";
    }
}

public class Cappuccino : IDrink
{
    public string GetDescription()
    {
        return "Cappuccino topped with frothy foam!";
    }
}

