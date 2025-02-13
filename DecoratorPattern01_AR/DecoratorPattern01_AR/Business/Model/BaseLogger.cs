namespace DecoratorPattern01_AR.Business.Model;

public class SimpleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"{message}");
    }
}
