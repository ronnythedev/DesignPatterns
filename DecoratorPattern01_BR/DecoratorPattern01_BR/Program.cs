using DecoratorPattern01_BR.Business.Module;

Console.WriteLine("This is a simple log message.");
var myLogger = new Logger();
myLogger.Log("The message");

Console.WriteLine("This is a timestamped log message.");
var myTimestampLogger = new TimestampLogger();
myTimestampLogger.Log("The message");

Console.WriteLine("This is an encrypted log message.");
var myEncryptedLogger = new EncryptedLogger();
myEncryptedLogger.Log("The message");

Console.WriteLine("This is an encrypted AND timestamped log message.");
var myTimestampEncryptedLogger = new TimestampAndEncryptedLogger();
myTimestampEncryptedLogger.Log("The message");