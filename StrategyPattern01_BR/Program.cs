using StrategyPattern01_BR.Business.Models;

NavigationApp app = new NavigationApp();

List<string> drivingRoute = app.CalculateDrivingRoute("Home", "Work");

Console.WriteLine("Driving Route:");

foreach (var step in drivingRoute)
{
    Console.WriteLine(step);
}

List<string> walkingRoute = app.CalculateWalkingRoute("Home", "Park");

Console.WriteLine("\nWalking Route:");

foreach (var step in walkingRoute)
{
    Console.WriteLine(step);
}

List<string> bikingRoute = app.CalculateBikingRoute("Home", "Gym");

Console.WriteLine("\nBiking Route:");

foreach (var step in bikingRoute)
{
    Console.WriteLine(step);
}