namespace StrategyPattern01_AR.Business.Models;
    
// Step 3: Implement the Context (NavigationApp)
public class NavigationApp
{
    private IRouteCalculationStrategy _routeStrategy;
    
    public NavigationApp(IRouteCalculationStrategy routeStrategy)
    {
        _routeStrategy = routeStrategy;
    }
    
    public void ShowRoute(string start, string end)
    {
        var routeSteps = _routeStrategy.CalculateRoute(start, end);
        
        foreach (var step in routeSteps)
        {
            Console.WriteLine(step);
        }
    }

}

