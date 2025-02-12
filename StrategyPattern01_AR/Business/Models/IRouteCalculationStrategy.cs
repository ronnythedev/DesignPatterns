namespace StrategyPattern01_AR.Business.Models;

    // Step 1: Define the Strategy Interface
    public interface IRouteCalculationStrategy
    {
        List<string> CalculateRoute(string start, string end);
        double CalculateEstimatedTime(string start, string end);
        double CalculateEstimatedCost(string start, string end);
    }

