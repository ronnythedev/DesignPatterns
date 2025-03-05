namespace FactoryMethodPattern01_AR.Business.Model;

public abstract class DrinkCreator
{
    protected abstract IDrink CreateDrink();

    public string ServeDrink()
    {
        var drink = CreateDrink();
        return drink.GetDescription();
    }
}

