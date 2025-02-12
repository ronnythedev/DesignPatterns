using StrategyPattern01_AR.Business.Models;

Console.WriteLine("=== Strategy Pattern: After Refactor ===\n");

var app = new NavigationApp(new DrivingRoute());

Console.WriteLine("Driving route...");
app.ShowRoute("Home", "Work");

app = new NavigationApp(new WalkingRoute());
Console.WriteLine("\nWalking route...");
app.ShowRoute("Home", "Park");

app = new NavigationApp(new BikingRoute());
Console.WriteLine("\nBiking route...");
app.ShowRoute("Home", "Gym");
