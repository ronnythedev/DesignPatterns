namespace FactoryMethodPattern01_AR.Business.Model;

public class EspressoCreator : DrinkCreator
{
    protected override IDrink CreateDrink()
    {
        return new Espresso();
    }
}

public class LatteCreator : DrinkCreator
{
    protected override IDrink CreateDrink()
    {
        return new Latte();
    }
}

public class CappuccinoCreator : DrinkCreator
{
    protected override IDrink CreateDrink()
    {
        return new Cappuccino();
    }
}