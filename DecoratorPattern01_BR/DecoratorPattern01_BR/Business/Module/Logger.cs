namespace DecoratorPattern01_BR.Business.Module;

public class Logger
{
    public virtual void Log(string message)
    {
        Console.WriteLine($"Log: {message}");
    }
}

public class TimestampLogger : Logger
{
    public override void Log(string message)
    {
        base.Log($"{DateTime.Now} {message}");
    }
}

public class EncryptedLogger : Logger
{
    public override void Log(string message)
    {
        base.Log($"Encrypted: {message}");
    }
}

public class TimestampEncryptedLogger : Logger
{
    public override void Log(string message)
    {
        base.Log($"{DateTime.Now} Encrypted: {message}");
    }
}

// The nightmare continues for other combinations of loggers.
