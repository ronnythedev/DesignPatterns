using FactoryMethodPattern01_AR.Business.Model;

DrinkCreator creator = new EspressoCreator();
Console.WriteLine(creator.ServeDrink());

creator = new LatteCreator();
Console.WriteLine(creator.ServeDrink());
