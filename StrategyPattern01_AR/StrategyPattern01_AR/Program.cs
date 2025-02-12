using StrategyPattern01_AR.Business.Models;

Console.WriteLine("=== Strategy Pattern: After Refactor ===\n");

var app = new NavigationApp(new DrivingRoute());
app.ShowRoute("Home", "Work");

Console.WriteLine("\nSwitching to walking route...\n");
app.SetRouteStrategy(new WalkingRoute());
app.ShowRoute("Home", "Park");

Console.WriteLine("\nSwitching to biking route...\n");
app.SetRouteStrategy(new BikingRoute());
app.ShowRoute("Home", "Gym");
