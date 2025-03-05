using FactoryMethodPattern01_BR.Business.Model;

var shop = new CoffeeShop();
Console.WriteLine(shop.MakeDrink("Espresso"));
Console.WriteLine(shop.MakeDrink("Latte"));
