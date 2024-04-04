class Program
{
    static void Main(string[] args)
    {
        FileLogger fileLogger = new FileLogger();

        fileLogger.Log("This is a log message");
        fileLogger.Error("This is an error message");
        fileLogger.Warn("This is a warning message");
    }
}
