namespace StrategyPattern01_AR.Business.Models;
    
public class NavigationApp
{
    private IRouteCalculationStrategy _routeStrategy;
    
    public NavigationApp(IRouteCalculationStrategy routeStrategy)
    {
        _routeStrategy = routeStrategy;
    }
    
    public void SetRouteStrategy(IRouteCalculationStrategy routeStrategy)
    {
        _routeStrategy = routeStrategy;
    }
    
    public void ShowRoute(string start, string end)
    {
        var route = _routeStrategy.CalculateRoute(start, end);
        
        foreach (var step in route)
        {
            Console.WriteLine(step);
        }
        
        Console.WriteLine($"Estimated Time: {_routeStrategy.CalculateEstimatedTime(start, end)} minutes");
        Console.WriteLine($"Estimated Cost: ${_routeStrategy.CalculateEstimatedCost(start, end)}");
    }

}

