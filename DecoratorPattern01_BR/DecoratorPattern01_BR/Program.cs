using DecoratorPattern01_BR.Business.Module;

var myLogger = new Logger();

myLogger.Log("This is a simple log message.");

var myTimestampLogger = new TimestampLogger();

myTimestampLogger.Log("This is a timestamped log message.");

var myEncryptedLogger = new EncryptedLogger();

myEncryptedLogger.Log("This is an encrypted log message.");

var myTimestampEncryptedLogger = new TimestampEncryptedLogger();

myTimestampEncryptedLogger.Log("This is a timestamped AND encrypted log message.");