namespace StrategyPattern01_BR.Business.Models;

public class NavigationApp
{
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