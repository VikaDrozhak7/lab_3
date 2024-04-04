public class FileLogger : Logger
{
    private FileWriter _fileWriter;
    private Logger _consoleLogger;

    public FileLogger()
    {
        _fileWriter = new FileWriter();
        _consoleLogger = new Logger();
    }

    public new void Log(string message)
    {
        _fileWriter.WriteLine(message);
        _consoleLogger.Log(message);
    }

    public new void Error(string message)
    {
        _fileWriter.WriteLine(message);
        _consoleLogger.Error(message);
    }

    public new void Warn(string message)
    {
        _fileWriter.WriteLine(message);
        _consoleLogger.Warn(message);
    }
}
