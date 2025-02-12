namespace StrategyPattern01_AR.Business.Models;

// Step 2: Implement Different Route Strategies (Concrete Strategies)
public class DrivingRoute : IRouteCalculationStrategy
{
    public List<string> CalculateRoute(string start, string end)
    {
        Console.WriteLine("Calculating driving route...");
        return new List<string>
        {
            $"Start at {start}", 
            "Drive on Highway 101", 
            $"Arrive at {end}"
        };
    }
}
    
public class WalkingRoute : IRouteCalculationStrategy
{
    public List<string> CalculateRoute(string start, string end)
    {
        Console.WriteLine("Calculating walking route...");
        return new List<string>
        {
            $"Start at {start}", 
            "Walk through the park", 
            $"Arrive at {end}"
        };
    }
}
    
public class BikingRoute : IRouteCalculationStrategy
{
    public List<string> CalculateRoute(string start, string end)
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
