namespace FactoryPattern_Simple01_AR.Business.Model;

public abstract class CharacterFactory
{
    public static ICharacter CreateCharacter(string type)
    {
        return type.ToLower() switch
        {
            "wizard" => new Wizard(),
            "knight" => new Knight(),
            "rogue" => new Rogue(),
            _ => throw new ArgumentException("Uh-oh, no such character!")
        };
    }
}

