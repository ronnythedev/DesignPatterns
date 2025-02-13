namespace DecoratorPattern01_BR.Business.Module;

public class Logger
{
    public virtual void Log(string message)
    {
        Console.WriteLine($"{message}");
    }
}

public class TimestampLogger : Logger
{
    public override void Log(string message)
    {
        base.Log($"{DateTime.Now}: {message}");
    }
}

public class EncryptedLogger : Logger
{
    public override void Log(string message)
    {
        base.Log($"Encrypted: {Encrypt(message)}");
    }
    
    private string Encrypt(string message)
    {
        return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(message));
    }
}

// If we want to combine the EncryptedLogger and TimestampLogger, we need to create a new class.
// Imagine if we have 30 different loggers and we want to combine all of them in different ways!
public class TimestampAndEncryptedLogger : Logger
{
    public override void Log(string message)
    {
        base.Log($"{DateTime.Now}, Encrypted: {Encrypt(message)}");
    }
    
    private string Encrypt(string message)
    {
        return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(message));
    }
}

// The nightmare continues for other combinations of loggers.
