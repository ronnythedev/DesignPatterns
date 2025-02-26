using FactoryPattern_Simple01_BR.Business.Model;

Console.WriteLine("Choose your character: Wizard, Knight, Rogue");
var choice = Console.ReadLine()?.ToLower();

switch (choice)
{
    case "wizard":
        var wizard = new Wizard();
        Console.WriteLine(wizard.PerformAction());
        break;
    case "knight":
        var knight = new Knight();
        Console.WriteLine(knight.PerformAction());
        break;
    case "rogue":
        var rogue = new Rogue();
        Console.WriteLine(rogue.PerformAction());
        break;
    default:
        Console.WriteLine("Uh-oh, no such character!");
        break;
}
