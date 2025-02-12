namespace StrategyPattern01_AR.Business.Models;

// Step 1: Define the Strategy Interface (IStrategy)
public interface IRouteCalculationStrategy
{ 
    List<string> CalculateRoute(string start, string end);
}

