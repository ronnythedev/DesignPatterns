using StrategyPattern01_BR.Business.Models;

Console.WriteLine("=== Strategy Pattern: Before Refactor ===\n");

var app = new NavigationApp();

var drivingRoute = app.CalculateDrivingRoute("Home", "Work");

Console.WriteLine("Driving Route:");

foreach (var step in drivingRoute)
{
    Console.WriteLine(step);
}

var walkingRoute = app.CalculateWalkingRoute("Home", "Park");

Console.WriteLine("\nWalking Route:");

foreach (var step in walkingRoute)
{
    Console.WriteLine(step);
}

var bikingRoute = app.CalculateBikingRoute("Home", "Gym");

Console.WriteLine("\nBiking Route:");

foreach (var step in bikingRoute)
{
    Console.WriteLine(step);
}