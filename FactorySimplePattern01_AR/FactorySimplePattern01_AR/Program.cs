using FactoryPattern_Simple01_AR.Business.Model;

Console.WriteLine("Choose your character: Wizard, Knight, Rogue");
var choice = Console.ReadLine();

try
{
    if (choice != null)
    {
        var character = CharacterFactory.CreateCharacter(choice);
        character.PerformAction();
    }
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}

