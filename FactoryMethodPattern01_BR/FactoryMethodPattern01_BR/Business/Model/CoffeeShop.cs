namespace FactoryMethodPattern01_BR.Business.Model;

public class CoffeeShop
{
    public string MakeDrink(string type)
    {
        if (type == "Espresso")
        {
            return "Espresso brewed with bold flavor!";
        }
        
        if (type == "Latte")
        {
            return "Latte crafted with steamed milk!";
        }
        
        if (type == "Cappuccino")
        {
            return "Cappuccino topped with frothy foam!";
        }
        
        return "Sorry, we don’t make that!";
    }
}
