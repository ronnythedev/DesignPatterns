namespace StrategyPattern01_AR.Business.Models;

    // Step 2: Implement Different Route Strategies
    public class DrivingRoute : IRouteCalculationStrategy
    {
        public List<string> CalculateRoute(string start, string end)
        {
            Console.WriteLine("Calculating driving route...");
            return new List<string> { $"Start at {start}", "Drive on Highway 101", $"Arrive at {end}" };
        }

        public double CalculateEstimatedTime(string start, string end)
        {
            return 30;
        }

        public double CalculateEstimatedCost(string start, string end)
        {
            return 5.00;
        }
    }
    
    public class WalkingRoute : IRouteCalculationStrategy
    {
        public List<string> CalculateRoute(string start, string end)
        {
            Console.WriteLine("Calculating walking route...");
            return new List<string> { $"Start at {start}", "Walk through the park", $"Arrive at {end}" };
        }

        public double CalculateEstimatedTime(string start, string end)
        {
            return 60;
        }

        public double CalculateEstimatedCost(string start, string end)
        {
            return 0.00;
        }
    }
    
    public class BikingRoute : IRouteCalculationStrategy
    {
        public List<string> CalculateRoute(string start, string end)
        {
            Console.WriteLine("Calculating biking route...");
            return new List<string> { $"Start at {start}", "Bike on the trail", $"Arrive at {end}" };
        }

        public double CalculateEstimatedTime(string start, string end)
        {
            return 45;
        }
        
        public double CalculateEstimatedCost(string start, string end)
        {
            return 0.00;
        }
    }
