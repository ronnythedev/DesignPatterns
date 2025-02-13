namespace DecoratorPattern01_AR.Business.Model;

public class TimestampLogger: LoggerDecorator
{
    public TimestampLogger(ILogger logger) : base(logger) { }

    public override void Log(string message)
    {
        var timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        _logger.Log($"{timestamp}: {message}");
    }
}

public class EncryptedLogger: LoggerDecorator
{
    public EncryptedLogger(ILogger logger) : base(logger) { }

    public override void Log(string message)
    {
        var encryptedMessage = Encrypt(message);
        _logger.Log($"Encrypted: {encryptedMessage}");
    }

    private string Encrypt(string message)
    {
        return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(message));
    }
}