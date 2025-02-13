using DecoratorPattern01_AR.Business.Model;

// Use a simple logger
Console.WriteLine("This is a simple log message.");
ILogger logger = new SimpleLogger();
logger.Log("The message");

// Use a timestamped logger
Console.WriteLine("This is a timestamped log message.");
var timestampLogger = new TimestampLogger(new SimpleLogger());
timestampLogger.Log("The message");

// Use an encrypted logger
Console.WriteLine("This is an encrypted log message.");
var encryptedLogger = new EncryptedLogger(new SimpleLogger());
encryptedLogger.Log("The message");


// Now combine the timestamped and encrypted loggers
// We don't have to create a new class for this
// We can just combine the decorators no matter how many we have
Console.WriteLine("This is an encrypted AND timestamped log message.");
ILogger combinedLogger = new SimpleLogger();
combinedLogger = new TimestampLogger(combinedLogger);
combinedLogger = new EncryptedLogger(combinedLogger);
combinedLogger.Log("The message");