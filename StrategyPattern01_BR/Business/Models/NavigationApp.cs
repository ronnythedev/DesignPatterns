namespace StrategyPattern01_BR.Business.Models;

public class NavigationApp
{
    // Here is the problem: When we need a new type of route, we need to add a new method to this class.
    // This breaks the Open/Closed Principle.
    public List<string> CalculateDrivingRoute(string start, string end)
    {
        Console.WriteLine("Calculating driving route...");
        return new List<string>
        {
            $"Start at {start}", 
            "Drive on Highway 101", 
            $"Arrive at {end}"
        };
    }
    
    public List<string> CalculateWalkingRoute(string start, string end)
    {
        Console.WriteLine("Calculating walking route...");
        return new List<string>
        {
            $"Start at {start}", 
            "Walk through the park", 
            $"Arrive at {end}"
        };
    }
    
    public List<string> CalculateBikingRoute(string start, string end)
    {
        Console.WriteLine("Calculating biking route...");
        return new List<string>
        {
            $"Start at {start}", 
            "Bike on the trail", 
            $"Arrive at {end}"
        };
    }
}